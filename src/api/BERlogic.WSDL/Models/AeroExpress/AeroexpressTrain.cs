using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Payment;
using BERlogic.WSDL.Services;

using Phaenir.Common.Models;

namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <remarks/>
    /// <summary>
    /// Used in <see cref="AeroexpressTicket"/> and <see cref="SearchAeroexpressTrainInfoResponse"/> and contains Aeroexpress train information
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class AeroexpressTrain : ITransportRestaurant, ITransportSchedule
    {
        /// <remarks/>
        /// <summary>
        /// Contains a list of payment types, the fees and the currencies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("allowedPaymentType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public Payment.PaymentTypeWithFee[] AllowedPaymentType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Arrival date for train.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "arrival", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Arrival { get; set; }

        /// <remarks/>
        /// <summary>
        /// Arrival time.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "arrivalTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string ArrivalTime { get; set; }

        /// <remarks/>
        /// <summary>
        /// A token that contains internal binary data that must be preserved for later usage
        /// in the booking process.
        /// <para>Within each flight object there is a so-called context which is important to be
        /// inserted in the following requests if referring to that flight.It is different for
        /// every flight and can not be switched between two differing flights.Since it is
        /// unique for a single flight, it can be cached along with the flight.</para>
        /// In the same way the context is used for <see cref="AirTicket"/>, <see cref="CostElement"/>, <see cref="FlightSegment"/>, <see cref="AeroexpressTrain"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "context", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 3)]
        public byte[] Context { get; set; }

        /// <remarks/>
        /// <summary>
        /// Cost of AeroExpress ticket.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public Cost Cost { get; set; }

        /// <remarks/>
        /// <summary>
        /// Departure date.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "departure", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string Departure { get; set; }

        /// <remarks/>
        /// <summary>
        /// Departure time.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "departureTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string DepartureTime { get; set; }

        /// <remarks/>
        /// <summary>
        /// Locale based on Agent's location.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locale", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string Locale { get; set; }

        /// <remarks/>
        /// <summary>
        /// Maximal days of schedule validity.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxDays", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public int MaxDays { get; set; }

        /// <remarks/>
        /// <summary>
        /// Amount of required seats. One seat equals to one ticket.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maxTickets", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public int MaxTickets { get; set; }

        /// <remarks/>
        /// <summary>
        /// Chosed food in train's restaurant.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "menuId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public int MenuId { get; set; }

        /// <remarks/>
        /// <summary>
        /// The type of order.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "orderType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public int OrderType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Schedule id.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "scheduleId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public int ScheduleId { get; set; }

        /// <remarks/>
        /// <summary>
        /// Possible service class.
        /// It is allowed to use only uppercase letter.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public ServiceClass ServiceClass { get; set; }

        /// <remarks/>
        /// <summary>
        /// The date and time when ticket and schedule is valid on.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "validOn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public System.DateTime ValidOn { get; set; }
    }
}