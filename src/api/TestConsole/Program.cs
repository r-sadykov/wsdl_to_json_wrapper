using System;

using BERlogic.Wrapper;
using BERlogic.WSDL.Common;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace TestConsole
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        /// <summary>
        /// Mains the.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <returns>A System.Threading.Tasks.Task.</returns>
        private static async System.Threading.Tasks.Task Main()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            BerlogicAgent agent = new()
            {
                AgencyCode = builder["DefinedAgent:AgencyCode"],
                AgentCode = builder["DefinedAgent:AgentCode"],
                AgentPassword = builder["DefinedAgent:AgentPassword"],
                Lang = builder["DefinedAgent:Lang"],
                PreferredCurrency = builder["DefinedAgent:PreferredCurrency"],
                SalesPoint = new BERlogic.WSDL.Models.Agencies.SalesPoint
                {
                    Code = builder["DefinedAgent:PointCode"],
                    Name = builder["DefinedAgent:PointName"],
                    TimeZone = builder["DefinedAgent:TimeZone"]
                }
            };

            #region GetBooking

            #endregion
            Console.WriteLine("Search:");
            await SearchRequestRebuilded.ResultAsync(agent).ConfigureAwait(false);

            Console.ReadKey();
            Console.WriteLine("Booking Info:");
            InfoConnectRebuilded connect = new(agent: agent);
            var requestToDB = connect.SetRequestToReportDB("VNUDPA", new DateTime(2021, 02, 16), new DateTime(2021, 03, 16));
            var xml = InfoConnectRebuilded.GetXmlCode(requestToDB);
            Console.WriteLine(xml);
            var responseFromDB = await connect.GetResponseFromReportDBAsync(requestToDB).ConfigureAwait(false);
            xml = InfoConnectRebuilded.GetXmlCode(responseFromDB);
            Console.WriteLine(xml);
            InfoConnectRebuilded.PrintResponseFromReportDB(responseFromDB);
            var booking = InfoConnectRebuilded.GetBookingNumber("VNUDPA", responseFromDB);
            xml = InfoConnectRebuilded.GetXmlCode(booking);
            Console.WriteLine(xml);
            var info_booking = connect.SetBookingRequest(booking);
            xml = InfoConnectRebuilded.GetXmlCode(info_booking);
            Console.WriteLine(xml);
            var response = await connect.GetBookingResponseAsync(info_booking).ConfigureAwait(false);
            xml = InfoConnectRebuilded.GetXmlCode(response);
            Console.WriteLine(xml);
            InfoConnectRebuilded.PrintBookingInformation(response);
        }
    }

    public interface ISecretRevealer
    {
        void Reveal();
    }

    public class SecretRevealer : ISecretRevealer
    {
        private readonly DefinedAgent _secrets;
        // I’ve injected <em>secrets</em> into the constructor as setup in Program.cs
        public SecretRevealer(IOptions<DefinedAgent> secrets)
        {
            // We want to know if secrets is null so we throw an exception if it is
            _secrets = secrets.Value ?? throw new ArgumentNullException(nameof(secrets));
        }

        public void Reveal()
        {
            //I can now use my mapped secrets below.
            Console.WriteLine($"Secret One: {_secrets.AgentCode}");
            Console.WriteLine($"Secret Two: {_secrets.PointCode}");
        }
    }
}
