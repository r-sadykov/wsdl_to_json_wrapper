using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Payment;
using BERlogic.WSDL.Services;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Used in <see cref="AirTicket"/> and <see cref="SearchFlightsResponse"/> and contains flight information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Flight
    {
        /// <remarks/>
        /// <summary>
        /// Contains the list of payment types, the fees and the currencies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("allowedPaymentType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public PaymentTypeWithFee[] AllowedPaymentType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Identifies the channel in the BERlogic system to which the request should be routed in all cases when such routing is relevant (for example to request the queues for particular GDS).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "channelId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string ChannelId { get; set; }

        /// <remarks/>
        /// <summary>
        /// A token that contains internal binary data that must be preserved for later usage in the booking process.
        /// <para>Within each flight object there is a so-called context which is important to be inserted in the following requests if referring to that flight. It is different for every flight and can not be switched between two differing flights. Since it is unique for a single flight, it can be cached along with the flight.</para>
        /// In the same way the context is used for <see cref="AirTicket"/>, <see cref="CostElement"/>, <see cref="FlightSegment"/>, <see cref="AeroexpressTrain"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "context", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 2)]
        public byte[] Context { get; set; }

        /// <remarks/>
        /// <summary>
        /// The cost of the flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Cost Cost { get; set; }

        /// <remarks/>
        /// <summary>
        /// If the flight is an e-Ticket or conventional ticket.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "eticket", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public bool ETicket { get; set; }

        /// <remarks/>
        /// <summary>
        /// Exchange rate for multicurrency order.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "exchangeRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public double ExchangeRate { get; set; }

        /// <remarks/>
        /// <summary>
        /// If true, passenger information must consist of latin characters only.
        /// If false, passenger information can consist of latin or cyrillic characters.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "latinRegistration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public bool LatinRegistration { get; set; }

        /// <remarks/>
        /// <summary>
        /// If true, passport information in passenger information is required.
        /// If false, passport information in passenger information is not mandatory
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "passportRequired", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public bool PassportRequired { get; set; }

        /// <remarks/>
        /// <summary>
        /// Determines whether the flight can be reserved for the later payment and ticketing or should be paid and ticketed immediately.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reservable", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public bool Reservable { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines segments of the flight. May occur one or more times.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("segments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public FlightSegment[] Segments { get; set; }

        /// <remarks/>
        /// <summary>
        /// Determines the time by which the flight can be ticketed. Time is by UTC and this time does not correspond to the time zone configured for the sales point.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public System.DateTime TimeLimit { get; set; }
    }
}