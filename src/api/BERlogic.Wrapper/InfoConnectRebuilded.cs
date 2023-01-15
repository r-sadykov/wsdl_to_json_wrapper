using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BERlogic.WSDL.Client;
using BERlogic.WSDL.Common;
using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Agencies;
using BERlogic.WSDL.Models.Bookings;
using BERlogic.WSDL.Services;

namespace BERlogic.Wrapper
{
    /// <summary>
    /// BookingInfo
    /// </summary>
    public class InfoConnectRebuilded
    {
        // https://services.berlogic.de/Partner/BookingInfo/v3
        // https://connect.berlogic.de/Partner/BookingInfo/v3

        private readonly BerlogicAgent _agent;
        private readonly BERlogicClient _bookingInfoClient;
        private readonly string _endpointUrl;

        /// <summary>
        /// BookingInfo
        /// </summary>
        /// <param name="endpointUrl"></param>
        public InfoConnectRebuilded(string endpointUrl = "https://connect.test.de/Partner/BookingInfo/v3", BerlogicAgent agent = null)
        {
            _agent = agent;
            _endpointUrl = endpointUrl;
            _bookingInfoClient = new BERlogicClient(_endpointUrl, new TimeSpan(1 * TimeSpan.TicksPerMinute), _agent);
        }

        /// <summary>
        /// SetRequestToReportDB
        /// </summary>
        /// <param name="searchParameter"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public GetBookingInfosFromReportDB SetRequestToReportDB(string searchParameter, DateTime from, DateTime to)
        {
            var searchParams = new BookingSearchParameter
            {
                BookingStatus = (new BookingStatus?[] { BookingStatus.COMPLETED }),
                DateFrom = from,
                DateTo = to,
                SearchFields = new SearchFields?[] { SearchFields.PNR },
                SearchText = searchParameter
            };
            GetBookingInfosFromReportDB request = new(_agent, searchParams);
            return request;
        }
        /// <summary>
        /// GetXmlCode
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static string GetXmlCode<T>(T xml)
        {
            var serxml = new System.Xml.Serialization.XmlSerializer(xml.GetType());
            var ms = new MemoryStream();
            serxml.Serialize(ms, xml);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
        /// <summary>
        /// GetResponseFromReportDBAsync
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetBookingInfosFromReportDBResponse> GetResponseFromReportDBAsync(GetBookingInfosFromReportDB request)
        {
            return await _bookingInfoClient.GetBookingInfosFromReportDBAsync(request).ConfigureAwait(false);
        }
        /// <summary>
        /// PrintResponseFromReportDB
        /// </summary>
        /// <param name="response"></param>
        public static void PrintResponseFromReportDB(GetBookingInfosFromReportDBResponse response)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");

            foreach (var item in response.OutlineBookings)
            {
                Console.WriteLine(item.Office + " / " + item.RecordLocator + " / " + item.AgencyCode + " / " + item.AgencyCode + " / " + item.HasInsurance + " / " + item.Stock + " / " + item.SSRFee + " / " + item.Stock + " / " + item.AgentCode + " / " + item.ClearingType + " / " + item.BookingNumber + " / " + item.Currency + " / " + item.TotalPrice + " / " + item.Date + " / " + item.TimeLimit + " / " + item.Status + " / " + item.ServiceLocators + " / " + item.ServiceCharge);
            }

            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
            Console.WriteLine("================================================");
        }

        /// <summary>
        /// GetBookingNumber
        /// </summary>
        /// <param name="searchParameter"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static OutlineBooking GetBookingNumber(string searchParameter, GetBookingInfosFromReportDBResponse response)
        {
            return response.OutlineBookings.First(c => c.RecordLocator == searchParameter || c.ServiceLocators == searchParameter);
        }

        /// <summary>
        /// PrintBooking
        /// </summary>
        /// <param name="booking"></param>
        public static void PrintBooking(OutlineBooking booking)
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*************************************************");

            Console.WriteLine(booking.Office + " / " + booking.RecordLocator + " / " + booking.AgencyCode + " / " + booking.AgencyCode + " / " + booking.HasInsurance + " / " + booking.Stock + " / " + booking.SSRFee + " / " + booking.AgentCode + " / " + booking.ClearingType + " / " + booking.BookingNumber + " / " + booking.Currency + " / " + booking.TotalPrice + " / " + booking.Date + " / " + booking.TimeLimit + " / " + booking.Status + " / " + booking.ServiceLocators + " / " + booking.ServiceCharge);

            Console.WriteLine("*************************************************");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*************************************************");
        }

        /// <summary>
        /// SetBookingRequest
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public GetBooking SetBookingRequest(OutlineBooking booking)
        {
            GetBooking request = new(_agent, booking.BookingNumber, 10000);
            return request;
        }

        /// <summary>
        /// GetBookingResponseAsync
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetBookingResponse> GetBookingResponseAsync(GetBooking request)
        {
            return await _bookingInfoClient.GetBookingAsync(request).ConfigureAwait(true);
        }

        /// <summary>
        /// PrintBookingInformation
        /// </summary>
        /// <param name="booking"></param>
        public static void PrintBookingInformation(GetBookingResponse booking)
        {
            Console.WriteLine(booking.Booking.AgencyCode);
            Console.WriteLine(booking.Booking.AgentCode);
            Console.WriteLine(booking.Booking.BookingNumber);

            Console.WriteLine(booking.Booking.Cost.Currency);
            Console.WriteLine(booking.Booking.Cost.Fee);
            Console.WriteLine(booking.Booking.Cost.SSRs);
            // NullReference
            if (booking.Booking.Cost.Surcharges is not null)
            {
                foreach (var item in booking.Booking.Cost.Surcharges)
                {
                    Console.WriteLine(item.Amount);
                    Console.WriteLine(item.Code);
                }
            }

            Console.WriteLine(booking.Booking.Customer.Company);
            Console.WriteLine(booking.Booking.Customer.HouseNumber);
            Console.WriteLine(booking.Booking.Customer.Birthday);
            Console.WriteLine(booking.Booking.Customer.PostAddress);
            Console.WriteLine(booking.Booking.Customer.Notes);
            Console.WriteLine(booking.Booking.Customer.Mobile);
            Console.WriteLine(booking.Booking.Customer.FullName);
            Console.WriteLine(booking.Booking.Customer.City);
            Console.WriteLine(booking.Booking.Customer.Country);
            Console.WriteLine(booking.Booking.Customer.Email);
            Console.WriteLine(booking.Booking.Customer.Fax);
            Console.WriteLine(booking.Booking.Customer.FirstName);
            Console.WriteLine(booking.Booking.Customer.Gender);
            Console.WriteLine(booking.Booking.Customer.IPAddress);
            Console.WriteLine(booking.Booking.Customer.LastName);
            Console.WriteLine(booking.Booking.Customer.MiddleName);
            Console.WriteLine(booking.Booking.Customer.Mobile);
            Console.WriteLine(booking.Booking.Customer.PhoneHome);
            Console.WriteLine(booking.Booking.Customer.PhoneWork);
            Console.WriteLine(booking.Booking.Customer.Region);
            Console.WriteLine(booking.Booking.Customer.ZipCode);

            Console.WriteLine(booking.Booking.Date);
            Console.WriteLine(booking.Booking.DelayTicketing);

            foreach (var item in booking.Booking.Documents)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Charset);
                Console.WriteLine(item.MimeType);
                Console.WriteLine(item.Type);
                Console.WriteLine(item.Data);
            }
            Console.WriteLine(booking.Booking.FailedCancellationInfo);

            foreach (var item in booking.Booking.LogItems)
            {
                Console.WriteLine(item.Message);
                Console.WriteLine(item.Date);
                Console.WriteLine(item.Severity);
            }

            Console.WriteLine(booking.Booking.Media);
            Console.WriteLine(booking.Booking.Notes);

            Console.WriteLine(booking.Booking.Payment.Timeout);
            Console.WriteLine(booking.Booking.Payment.Currency);
            Console.WriteLine(booking.Booking.Payment.Notes);
            Console.WriteLine(booking.Booking.Payment.PaymentFee);
            Console.WriteLine(booking.Booking.Payment.SuccessUrl);
            // NullReference
            if (booking.Booking.Payment.CreditCard is not null)
            {
                Console.WriteLine(booking.Booking.Payment.CreditCard.Number);
                Console.WriteLine(booking.Booking.Payment.CreditCard.CVC);
                Console.WriteLine(booking.Booking.Payment.CreditCard.Owner);

                Console.WriteLine(booking.Booking.Payment.CreditCard.SCA.XID);
                Console.WriteLine(booking.Booking.Payment.CreditCard.SCA.ECI);
                Console.WriteLine(booking.Booking.Payment.CreditCard.SCA.Protocol);
                Console.WriteLine(booking.Booking.Payment.CreditCard.SCA.DSID);
                Console.WriteLine(booking.Booking.Payment.CreditCard.SCA.Exceptions);
                Console.WriteLine(booking.Booking.Payment.CreditCard.SCA.SLI);
                Console.WriteLine(booking.Booking.Payment.CreditCard.SCA.UCAV);

                Console.WriteLine(booking.Booking.Payment.CreditCard.Expired);
                Console.WriteLine(booking.Booking.Payment.CreditCard.Vendor);
            }
            Console.WriteLine(booking.Booking.Payment.Code);
            Console.WriteLine(booking.Booking.Payment.Date);
            Console.WriteLine(booking.Booking.Payment.FailureUrl);
            Console.WriteLine(booking.Booking.Payment.IssueEMD90);
            if (booking.Booking.Payment.Lastschrift is not null)
            {
                Console.WriteLine(booking.Booking.Payment.Lastschrift.BIC);
                Console.WriteLine(booking.Booking.Payment.Lastschrift.Bank);
                Console.WriteLine(booking.Booking.Payment.Lastschrift.IBAN);
                Console.WriteLine(booking.Booking.Payment.Lastschrift.Owner);
            }
            Console.WriteLine(booking.Booking.Payment.Number);
            Console.WriteLine(booking.Booking.Payment.PaymentFee);
            Console.WriteLine(booking.Booking.Payment.PaymentPage);
            Console.WriteLine(booking.Booking.Payment.Price);
            Console.WriteLine(booking.Booking.Payment.Remark);
            Console.WriteLine(booking.Booking.Payment.State);
            Console.WriteLine(booking.Booking.Payment.TimeLimit);
            Console.WriteLine(booking.Booking.Payment.Type);

            // NullReference
            if (booking.Booking.Remarks is not null)
            {
                foreach (var item in booking.Booking.Remarks)
                {
                    Console.WriteLine(item.Details);
                    Console.WriteLine(item.Text);
                }
            }

            Console.WriteLine(booking.Booking.SalesPoint.Name);
            Console.WriteLine(booking.Booking.SalesPoint.Code);
            Console.WriteLine(booking.Booking.SalesPoint.TimeZone);

            foreach (var item in booking.Booking.Services)
            {
                if (item is SPZDBooking)
                {
                    Console.WriteLine((item as SPZDBooking)?.Cost);
                }
                else if (item is Insurance)
                {
                    Console.WriteLine((item as Insurance)?.InsuranceStatus);
                    Console.WriteLine((item as Insurance)?.TicketNumber);
                    Console.WriteLine((item as Insurance)?.Passenger.FareCalculation);
                    Console.WriteLine((item as Insurance)?.Passenger.Citizenship);
                    Console.WriteLine((item as Insurance)?.Passenger.Birthday);
                    Console.WriteLine((item as Insurance)?.Passenger.Category);
                    Console.WriteLine((item as Insurance)?.Passenger.Commission.Amount);
                    Console.WriteLine((item as Insurance)?.Passenger.Commission.Type);
                    Console.WriteLine((item as Insurance)?.Passenger.DiscountCardNumber);
                    foreach (var entry in (item as Insurance)?.Passenger.EmdSSRs)
                    {
                        Console.WriteLine(entry.Key);
                        Console.WriteLine(entry.Value);
                    }
                    Console.WriteLine((item as Insurance)?.Passenger.FirstName);
                    Console.WriteLine((item as Insurance)?.Passenger.Gender);
                    Console.WriteLine((item as Insurance)?.Passenger.IdCardExpireDate);
                    Console.WriteLine((item as Insurance)?.Passenger.IdCardNumber);
                    Console.WriteLine((item as Insurance)?.Passenger.IdCardType);
                    Console.WriteLine((item as Insurance)?.Passenger.LastName);
                    Console.WriteLine((item as Insurance)?.Passenger.MiddleName);
                    foreach (var entry in (item as Insurance)?.Passenger.SSRs)
                    {
                        Console.WriteLine(entry);
                    }
                    Console.WriteLine((item as Insurance)?.Passenger.TicketStatus);
                    Console.WriteLine((item as Insurance)?.Amount);
                    Console.WriteLine((item as Insurance)?.Created);
                    Console.WriteLine((item as Insurance)?.DeclarationDate);
                    Console.WriteLine((item as Insurance)?.DeclarationNumber);
                    Console.WriteLine((item as Insurance)?.Id);
                    Console.WriteLine((item as Insurance)?.ProductCode);
                    Console.WriteLine((item as Insurance)?.ProviderId);
                    Console.WriteLine((item as Insurance)?.PublicId);
                    Console.WriteLine((item as Insurance)?.Updated);
                }
                else if (item is HotelBooking)
                {
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.HotelName);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.HotelId);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.DestinationId);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.PartnerInvoiceNumber);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.CommissionAmount.Amount);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.CommissionAmount.Currency);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.CommissionPercent);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.DefaultCheckinTime);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.DefaultCheckoutTime);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.Fax);
                    foreach (var entry in (item as HotelBooking)?.HotelReservation.HotelComments)
                    {
                        Console.WriteLine(entry);
                    }
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.PartnerInvoiceNumber);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.PartnerReservationNumber);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.Phone);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.ReservationDate);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.ReservationId);
                    foreach (var entry in (item as HotelBooking)?.HotelReservation.Rooms)
                    {
                        Console.WriteLine(entry.PostPay);
                        Console.WriteLine(entry.RoomName);
                        Console.WriteLine(entry.TchRefundAmount);
                        Console.WriteLine(entry.BedType);
                        foreach (var line in entry.CancellationRules)
                        {
                            Console.WriteLine(line.Amount);
                            Console.WriteLine(line.Possible);
                            Console.WriteLine(line.UtcDateFrom);
                            Console.WriteLine(line.UtcDateTo);
                        }
                        Console.WriteLine(entry.Taxes.Amount);
                        Console.WriteLine(entry.Taxes.Currency);
                        Console.WriteLine(entry.CheckIn);
                        foreach (var line in entry.Guests)
                        {
                            Console.WriteLine(line.AdditionalNames);
                            Console.WriteLine(line.AdditionalNamesLocalized);
                            Console.WriteLine(line.Age);
                            Console.WriteLine(line.BirthDate);
                            Console.WriteLine(line.FamilyName);
                            Console.WriteLine(line.FamilyNameLocalized);
                            Console.WriteLine(line.FirstName);
                            Console.WriteLine(line.FirstNameLocalized);
                            Console.WriteLine(line.CitizenCountryCode);
                            foreach (var row in line.Passports)
                            {
                                Console.WriteLine(row.IssuePlace);
                                Console.WriteLine(row.Country);
                                Console.WriteLine(row.FamilyName);
                                Console.WriteLine(row.FirstName);
                                Console.WriteLine(row.IssueDate);
                                Console.WriteLine(row.IssuedBy);
                                Console.WriteLine(row.Number);
                                Console.WriteLine(row.Type);
                                Console.WriteLine(row.ValidUntil);
                            }
                            foreach (var row in line.PersonalDocuments)
                            {
                                Console.WriteLine(row.Key);
                                Console.WriteLine(row.Value);
                            }
                            Console.WriteLine(line.Sex);
                            Console.WriteLine(line.Title);
                            Console.WriteLine(line.TitleLocalized);
                        }
                        Console.WriteLine(entry.CheckOut);
                        Console.WriteLine(entry.HotelReservationNumber);
                        Console.WriteLine(entry.MealType);
                        Console.WriteLine(entry.NonRefundable);
                        Console.WriteLine(entry.OnRequest);
                        Console.WriteLine(entry.RoomDescription);
                        Console.WriteLine(entry.RoomType);
                        Console.WriteLine(entry.TchRefundEmd);
                        Console.WriteLine(entry.TchTicketAmount.Amount);
                        Console.WriteLine(entry.TchTicketAmount.Currency);
                        Console.WriteLine(entry.TchTicketEmdNumber);
                        Console.WriteLine(entry.TotalPrice.Amount);
                        Console.WriteLine(entry.TotalPrice.Currency);
                        Console.WriteLine(entry.VAT.Amount);
                        Console.WriteLine(entry.VAT.Currency);
                        Console.WriteLine(entry.Vendor);
                        Console.WriteLine(entry.VendorReservationId);
                    }
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.StarRating);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.TchReservationId);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.TotalPrice.Amount);
                    Console.WriteLine((item as HotelBooking)?.HotelReservation.TotalPrice.Currency);
                    Console.WriteLine((item as HotelBooking)?.TotalPrice.Amount);
                    Console.WriteLine((item as HotelBooking)?.TotalPrice.Currency);
                }
                else if (item is AeroexpressTicket)
                {
                    Console.WriteLine((item as AeroexpressTicket)?.ReservationId);
                    foreach (var line in (item as AeroexpressTicket)?.AeroexpressSeats)
                    {
                        Console.WriteLine(line.TicketNumber);
                        Console.WriteLine(line.Passenger.FirstName);
                        Console.WriteLine(line.Passenger.IdDocumentNumber);
                        Console.WriteLine(line.Passenger.IdDocumentType);
                        Console.WriteLine(line.Passenger.LastName);
                        Console.WriteLine(line.Passenger.MiddleName);
                    }
                    Console.WriteLine((item as AeroexpressTicket)?.TicketNumber);
                    Console.WriteLine((item as AeroexpressTicket)?.TicketUrl);
                    foreach (var row in (item as AeroexpressTicket)?.Train.AllowedPaymentType)
                    {
                        Console.WriteLine(row.Fee);
                        Console.WriteLine(row.FeeCurrency);
                        Console.WriteLine(row.Type);
                    }
                    Console.WriteLine((item as AeroexpressTicket)?.Train.Arrival);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.ArrivalTime);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.Cost);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.Departure);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.DepartureTime);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.Locale);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.MaxDays);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.MaxTickets);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.MenuId);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.OrderType);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.ScheduleId);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.ServiceClass);
                    Console.WriteLine((item as AeroexpressTicket)?.Train.ValidOn);
                }
                else
                {
                    foreach (var line in (item as AirTicket)?.Flight.AllowedPaymentType)
                    {
                        Console.WriteLine(line.Fee);
                        Console.WriteLine(line.FeeCurrency);
                        Console.WriteLine(line.Type);
                    }
                    Console.WriteLine((item as AirTicket)?.Flight.ChannelId);
                    Console.WriteLine((item as AirTicket)?.Flight.Cost.SSRs);
                    Console.WriteLine((item as AirTicket)?.Flight.Cost.Currency);
                    foreach (var line in (item as AirTicket)?.Flight.Cost.Elements)
                    {
                        Console.WriteLine(line.Category);
                        Console.WriteLine(line.Fee);
                        Console.WriteLine(line.FeeB);
                        Console.WriteLine(line.FeeP);
                        Console.WriteLine(line.Tariff);
                        Console.WriteLine(line.Taxes);
                    }
                    Console.WriteLine((item as AirTicket)?.Flight.Cost.Fee);
                    // NullReference
                    if ((item as AirTicket)?.Flight.Cost.Surcharges is not null)
                    {
                        foreach (var line in (item as AirTicket)?.Flight.Cost.Surcharges)
                        {
                            Console.WriteLine(line.Amount);
                            Console.WriteLine(line.Code);
                        }
                    }
                    Console.WriteLine((item as AirTicket)?.Flight.ETicket);
                    Console.WriteLine((item as AirTicket)?.Flight.ExchangeRate);
                    Console.WriteLine((item as AirTicket)?.Flight.LatinRegistration);
                    Console.WriteLine((item as AirTicket)?.Flight.PassportRequired);
                    Console.WriteLine((item as AirTicket)?.Flight.Reservable);
                    foreach (var line in (item as AirTicket)?.Flight.Segments)
                    {
                        Console.WriteLine(line.AirlineLocator);
                        Console.WriteLine(line.AirlineLogin);
                        Console.WriteLine(line.AirlinePassword);
                        Console.WriteLine(line.AirlineUrl);
                        Console.WriteLine(line.BeginDate);
                        Console.WriteLine(line.BeginLocation.CountryId);
                        Console.WriteLine(line.BeginLocation.DisplayCode);
                        Console.WriteLine(line.BeginLocation.Id);
                        Console.WriteLine(line.BeginLocation.Name);
                        Console.WriteLine(line.BeginLocation.ParentLocationId);
                        Console.WriteLine(line.BeginLocation.RailwayCodeId);
                        Console.WriteLine(line.BeginLocation.Type);
                        Console.WriteLine(line.Board);
                        Console.WriteLine(line.BoardCode);
                        Console.WriteLine(line.BookingClass);
                        Console.WriteLine(line.Connected);
                        Console.WriteLine(line.EndDate);
                        Console.WriteLine(line.EndLocation.CountryId);
                        Console.WriteLine(line.EndLocation.DisplayCode);
                        Console.WriteLine(line.EndLocation.Id);
                        Console.WriteLine(line.EndLocation.Name);
                        Console.WriteLine(line.EndLocation.ParentLocationId);
                        Console.WriteLine(line.EndLocation.RailwayCodeId);
                        Console.WriteLine(line.EndLocation.Type);
                        Console.WriteLine(line.FareBasis);
                        Console.WriteLine(line.FlightNumber);
                        Console.WriteLine(line.LuggageAllowed);
                        Console.WriteLine(line.MarketingVendor.DisplayCode);
                        Console.WriteLine(line.MarketingVendor.Id);
                        Console.WriteLine(line.MarketingVendor.Name);
                        Console.WriteLine(line.OperatingVendor.DisplayCode);
                        Console.WriteLine(line.OperatingVendor.Id);
                        Console.WriteLine(line.OperatingVendor.Name);
                        Console.WriteLine(line.Seats);
                        Console.WriteLine(line.ServiceClass);
                        // NullReference
                        if (line.SSRs is not null)
                        {
                            foreach (var row in line.SSRs)
                            {
                                Console.WriteLine(row.Id);
                                Console.WriteLine(row.AmountOfPieces);
                                Console.WriteLine(row.RFIC);
                                Console.WriteLine(row.RFISC);
                                Console.WriteLine(row.Tariff);
                                Console.WriteLine(row.Taxes);
                                Console.WriteLine(row.Type);
                                Console.WriteLine(row.Weight);
                                Console.WriteLine(row.WeightType);
                                Console.WriteLine(row.WholeLeg);
                            }
                        }
                        if (line.Stops is not null)
                        {
                            foreach (var row in line.Stops)
                            {
                                Console.WriteLine(row.Begin);
                                Console.WriteLine(row.Board);
                                Console.WriteLine(row.BoardCode);
                                Console.WriteLine(row.End);
                                Console.WriteLine(row.Location.CountryId);
                                Console.WriteLine(row.Location.DisplayCode);
                                Console.WriteLine(row.Location.Id);
                                Console.WriteLine(row.Location.Name);
                                Console.WriteLine(row.Location.ParentLocationId);
                                Console.WriteLine(row.Location.RailwayCodeId);
                                Console.WriteLine(row.Location.Type);
                            }
                        }
                        Console.WriteLine(line.TerminalBegin);
                        Console.WriteLine(line.TerminalEnd);
                        Console.WriteLine(line.TravelDuration);
                        Console.WriteLine(line.Vendor.DisplayCode);
                        Console.WriteLine(line.Vendor.Id);
                        Console.WriteLine(line.Vendor.Name);
                    }
                    Console.WriteLine((item as AirTicket)?.Flight.TimeLimit);
                    Console.WriteLine((item as AirTicket)?.Imported);
                    // NullReference
                    if ((item as AirTicket)?.Passengers is not null)
                    {
                        Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
                        var obj = (item as AirTicket)?.Passengers;
                        int len = obj.Length;
                        Console.WriteLine(len);
                        Console.WriteLine(obj);

                        for (int i = 0; i < len; i++)
                        {
                            Console.WriteLine(obj[i].Birthday);
                            Console.WriteLine(obj[i].Category);
                            Console.WriteLine(obj[i].Citizenship);
                            if (obj[i].Commission is not null)
                            {
                                Console.WriteLine(obj[i].Commission.Amount);
                                Console.WriteLine(obj[i].Commission.Type);
                            }
                            Console.WriteLine(obj[i].DiscountCardNumber);
                            if (obj[i].EmdSSRs is not null)
                            {
                                foreach (var row in obj[i].EmdSSRs)
                                {
                                    Console.WriteLine(row.Key);
                                    Console.WriteLine(row.Value);
                                }
                            }
                            Console.WriteLine(obj[i].FareCalculation);
                            Console.WriteLine(obj[i].FirstName);
                            Console.WriteLine(obj[i].Gender);
                            Console.WriteLine(obj[i].IdCardExpireDate);
                            Console.WriteLine(obj[i].IdCardNumber);
                            Console.WriteLine(obj[i].LastName);
                            Console.WriteLine(obj[i].MiddleName);
                            if (obj[i].SSRs is not null)
                            {
                                foreach (var row in obj[i].SSRs)
                                {
                                    Console.WriteLine(row);
                                }
                            }
                            Console.WriteLine(obj[i].TicketNumber);
                            Console.WriteLine(obj[i].TicketStatus);
                        }
                        Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
                    }
                    Console.WriteLine((item as AirTicket)?.RecordLocator);
                    if ((item as AirTicket)?.SplitLocators is not null)
                    {
                        foreach (var line in (item as AirTicket)?.SplitLocators)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    Console.WriteLine((item as AirTicket)?.Stock);
                    Console.WriteLine((item as AirTicket)?.TimeLimit);
                }
            }
            Console.WriteLine(booking.Booking.Status);
        }
    }
}
