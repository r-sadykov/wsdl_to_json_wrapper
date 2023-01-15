using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Specifies the return data for <see cref="SearchScheduleResponse"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class ScheduleElement
    {
        /// <remarks/>
        /// <summary>
        /// The array of prefferable days of week for trip.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("applicableDays", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public System.Nullable<DayOfTheWeek>[] ApplicableDays { get; set; }

        /// <remarks/>
        /// <summary>
        /// The explicit aircraft name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "board", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Board { get; set; }

        /// <remarks/>
        /// <summary>
        /// Holds a code for the aircraft type, if available. May not be available for every flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "boardCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string BoardCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// The city name of the starting point.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cityBegin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string CityBegin { get; set; }

        /// <remarks/>
        /// <summary>
        /// The city name of the end point.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cityEnd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string CityEnd { get; set; }

        /// <remarks/>
        /// <summary>
        /// Shows if this segment is connected to the previous segment.
        /// <para>A flight can contain multiple segments. Even a leg can contain multiple segments (in the case of a stop-over flight). If two flight segments belong to the same leg, the second segment will have set its connected property to true. Therefore, the first segment of a new leg will always have connected = false, every other segment on the same leg will have connected = true.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "connected", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public bool Connected { get; set; }

        /// <remarks/>
        /// <summary>
        /// The flight number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "flightNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string FlightNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// The airport or city code of the starting point.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationBegin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string LocationBegin { get; set; }

        /// <remarks/>
        /// <summary>
        /// Airport or city code of the end point.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "locationEnd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string LocationEnd { get; set; }

        /// <remarks/>
        /// <summary>
        /// Indicate that flight finish in next day.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "nextDay", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public bool NextDay { get; set; }

        /// <remarks/>
        /// <summary>
        /// The departure date.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "periodBegin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public System.DateTime PeriodBegin { get; set; }

        /// <remarks/>
        /// <summary>
        /// The arrival date.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "periodEnd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public System.DateTime PeriodEnd { get; set; }

        /// <remarks/>
        /// <summary>
        /// The service class of the offered segment. It is allowed to use only uppercase letter.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("serviceClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 12)]
        public System.Nullable<ServiceClass>[] ServiceClass { get; set; }

        /// <remarks/>
        /// <summary>
        /// departure time.
        /// hh:mm
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeBegin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string TimeBegin { get; set; }

        /// <remarks/>
        /// <summary>
        /// arrival time.
        /// hh:mm
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeEnd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string TimeEnd { get; set; }

        /// <remarks/>
        /// <summary>
        /// The duration in minutes for this segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "travelDuration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public int TravelDuration { get; set; }

        /// <remarks/>
        /// <summary>
        /// The vendor (usually the airline), offering this element.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string Vendor { get; set; }
    }
}