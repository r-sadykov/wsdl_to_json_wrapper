using BERlogic.WSDL.Common;
using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Agencies;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Passengers;
using BERlogic.WSDL.Models.Payment;
using BERlogic.WSDL.Services;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <remarks/>
    /// <summary>
    /// Abstract type. Extends through the type of booking.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Booking))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public abstract partial class BookingBase
    {
        /// <remarks/>
        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string AgencyCode { get; set; }

        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AgentCode { get; set; }

        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AgentPassword { get; set; }

        /// <summary>
        /// The booking ID in the database of web services, i.e only for internal use in system. Booking number is returned in createReservationResponse.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bookingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string BookingNumber { get; set; }

        /// <summary>
        /// Certificate number, if required.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "certNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string CertNumber { get; set; }

        /// <summary>
        /// A token that contains internal binary data that must be preserved for later usage in the booking process.
        /// <para>Within each flight object there is a so-called context which is important to be inserted in the following requests if referring to that flight. It is different for every flight and can not be switched between two differing flights. Since it is unique for a single flight, it can be cached along with the flight.</para>
        /// In the same way the context is used for <see cref="AirTicket"/>, <see cref="CostElement"/>, <see cref="FlightSegment"/>, <see cref="AeroexpressTrain"/>.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "context", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 5)]
        public byte[] Context { get; set; }

        /// <summary>
        /// The cost of the whole booking.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public Cost Cost { get; set; }

        /// <summary>
        /// Contains customer (end-user) information.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "customer", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public Contact Customer { get; set; }

        /// <summary>
        /// The date of the booking.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// If false, then the ticketing will be done immediately after payment.
        /// <para>If true, then the ticketing will be postponed.</para>
        /// It defaults to false unless set explicitly by the partner. It must be set inside the <see cref="PreparePayment"/> request. A standard <see cref="FinishBooking"/> will just ignore the property and always ticket. Also note, that a <see cref="GetBooking"/> with timeToWait > 0 will internally trigger a <see cref="FinishBooking"/> attempt if the payment is acknowledged.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "delayTicketing", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public bool DelayTicketing { get; set; }

        /// <summary>
        /// One or more binary booking documents.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documents", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public Document[] Documents { get; set; }

        /// <summary>
        /// One or more logging messages from the BERlogic's system. Return-only parameter.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("logItems", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public BookingLogItem[] LogItems { get; set; }

        /// <summary>
        /// Version of payment pages (in <see cref="PreparePayment"/> request). Default setting is DESKTOP.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "media", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public Media Media { get; set; }

        /// <summary>
        /// Notes with additional comments about booking process.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "notes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string Notes { get; set; }

        /// <summary>
        /// Contains payment information.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "payment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public BERlogic.WSDL.Models.Payment.Payment Payment { get; set; }

        /// <summary>
        /// GDS remarks that can be transmitted to a partner in <see cref="ImportBookingResponse"/> / <see cref="UpdateBookingResponse"/> . The service is configurable per partner (tenant, agency) in BERlogic system using a special key value.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("remarks", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 15)]
        public Remark[] Remarks { get; set; }

        /// <summary>
        /// Salespoint information from wich all services orders made.
        /// Code of the salespoint that belongs to the agency created in the BERlogic system for partner's connection.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public SalesPoint SalesPoint { get; set; }

        /// <summary>
        /// The state of the booking.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public BookingStatus Status { get; set; }
    }
}