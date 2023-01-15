using BERlogic.WSDL.Models.Agencies;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <remarks/>
    /// <summary>
    /// Used in <see cref="GetBookingInfosFromReportDBResponse"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class OutlineBooking
    {
        /// <remarks/>
        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string AgencyCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AgentCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AgentPassword { get; set; }

        /// <remarks/>
        /// <summary>
        /// The booking ID in the database of web services, i.e only for internal use in system. Booking number is returned in createReservationResponse.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bookingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string BookingNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Clearing type of payment for service.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "clearingType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string ClearingType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Contact name of buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "contactName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string ContactName { get; set; }

        /// <remarks/>
        /// <summary>
        /// The currency in which this booking is offered and prices are represented. Supported: EUR, RUB.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "currency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string Currency { get; set; }

        /// <remarks/>
        /// <summary>
        /// Date of booking.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public System.DateTime Date { get; set; }

        /// <remarks/>
        /// <summary>
        /// Cancellation error type information.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "failedCancellationInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string FailedCancellationInfo { get; set; }

        /// <remarks/>
        /// <summary>
        /// Service type on first segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstServiceType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string FirstServiceType { get; set; }

        /// <remarks/>
        /// <summary>
        /// FOP fee.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fopFee", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string FOPFee { get; set; }

        /// <remarks/>
        /// <summary>
        /// Indicate that booking has insurance.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "hasInsurance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public bool HasInsurance { get; set; }

        /// <summary>
        /// Office that issued service.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "office", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string Office { get; set; }

        /// <summary>
        /// The "main" booking ID in the database of the GDS (e.g. PNR). It is a combination of six characters - letters and numbers.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "recordLocator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string RecordLocator { get; set; }

        /// <summary>
        /// Code of the salespoint that belongs to the agency created in the BERlogic system for partner's connection.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public SalesPoint SalesPoint { get; set; }

        /// <summary>
        /// Service charge.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceCharge", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public decimal ServiceCharge { get; set; }

        /// <summary>
        /// Service locators.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceLocators", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string ServiceLocators { get; set; }

        /// <summary>
        /// Special Service Reservation fee.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ssrFee", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public decimal SSRFee { get; set; }

        /// <summary>
        /// Status of booking order.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public string Status { get; set; }

        /// <summary>
        /// In which BERlogic's stock service was issued.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "stock", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public string Stock { get; set; }

        /// <summary>
        /// Determines the time (UTC) by which the flight can be ticketed.
        /// <para>If a reservation took place, this shows until when the reservation is valid. If there was no reservation due to restrictions of the airline, this will either show the time of now or some moment of the past. Time is by UTC and this time does not correspond to the time zone configured for the sales point.</para>
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public System.DateTime TimeLimit { get; set; }

        /// <summary>
        /// Total price for service.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalPrice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public decimal TotalPrice { get; set; }
    }
}