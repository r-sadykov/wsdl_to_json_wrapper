using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using BERlogic.WSDL.Client;
using BERlogic.WSDL.Common;
using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Airlines;

namespace BERlogic.Wrapper
{
    /// <summary>
    /// SearchRequestRebuilded
    /// </summary>
    public static class SearchRequestRebuilded
    {
        /// <summary>
        /// ResultAsync
        /// </summary>
        /// <returns></returns>
        public static async Task ResultAsync(BerlogicAgent agent)
        {
            //BERlogicClient client = new("https://connect.berlogic.de/Partner/Avia/v3", new TimeSpan(1 * TimeSpan.TicksPerMinute), agent);
            BERlogicClient client = new("https://vmdemo.test.de/Partner/Avia/v3", new TimeSpan(1 * TimeSpan.TicksPerMinute), agent);
            List<RouteSegment> segments = new();
            RouteSegment segment = new()
            {
                BeginLocation = "DME",
                EndLocation = "LED",
                Date = new DateTime(2021, 08, 15, 10, 00, 00, DateTimeKind.Utc),
            };
            segments.Add(segment);
            FlightSearchSettingsEntry[] entries = new FlightSearchSettingsEntry[]{
                new FlightSearchSettingsEntry
                    {
                        Key=PassengerCategory.ADULT,
                        Value=1,
                    },
                    new FlightSearchSettingsEntry
                    {
                        Key=PassengerCategory.CHILD,
                        Value=0,
                    },
                    new FlightSearchSettingsEntry
                    {
                        Key=PassengerCategory.INFANT,
                        Value=0,
                    }
            };
            FlightSearchSettings settings = new(agent)
            {
                DateTolerance = 0,
                MixedVendors = true,
                ETicketsOnly = true,
                SkipConnected = false,
                ServiceClass = ServiceClass.ECONOM,
                Route = segments.ToArray(),
                Seats = entries
            };
            SearchFlights search = new(settings);
            var serxml = new System.Xml.Serialization.XmlSerializer(search.GetType());
            var ms = new MemoryStream();
            serxml.Serialize(ms, search);
            string xml = Encoding.UTF8.GetString(ms.ToArray());
            Console.WriteLine(xml);
            await client.OpenAsync().ConfigureAwait(false);
            if (client.State == CommunicationState.Opened)
            {
                var resp = await client.SearchFlightsAsync(search).ConfigureAwait(false);

                if (resp is not null)
                {
                    foreach (var item in resp.Flights)
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine($"ChannelID: {item.ChannelId}\nFlight Number: [{item.Segments[0].FlightNumber}] Flight Board: [{item.Segments[0].Board}]\tRoute: {item.Segments[0].BeginLocation.DisplayCode}- {item.Segments[0].EndLocation.DisplayCode}\tTravel Duration: {item.Segments[0].TravelDuration}\tTariff:{item.Cost.Elements[0].Tariff} {item.Cost.Currency}\tTaxes:{item.Cost.Elements[0].Taxes} {item.Cost.Currency}\tExchange Rate: {item.ExchangeRate}");
                    }
                }
            }
        }
    }
}
