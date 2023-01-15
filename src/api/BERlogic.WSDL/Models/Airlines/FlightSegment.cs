using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Payment;
using BERlogic.WSDL.Services;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Used to describe the field segment in flight. Defines single actual flight between two airports and contains information about the airplane, start and end locations, departure and arrival times.
    /// <para>A flight can contain multiple segments. Even a leg can contain multiple segments (in the case of a stop-over flight). If two flight segments belong to the same leg, the second segment will have set its connected property to true. Therefore, the first segment of a new leg will always have connected = false, every other segment on the same leg will have connected = true.</para>
    /// For a oneway flight there will be only one leg (possibly with multiple segments), whereas a roundtrip flight will have two legs (which possibly multiple segments each). The ordering of segments thus important. Also segments can't be combined by the customer as is restricted by the airline. If another combination of segments is possible, a 2nd flight with these segments will be returned by a flight search.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class FlightSegment
    {
        /// <remarks/>
        /// <summary>
        /// For online registration for the flight. Sometimes empty as not all airlines provide it.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "airlineLocator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string AirlineLocator { get; set; }

        /// <remarks/>
        /// <summary>
        /// Login to airline system
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "airlineLogin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AirlineLogin { get; set; }

        /// <remarks/>
        /// <summary>
        /// Password to airline system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "airlinePassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AirlinePassword { get; set; }

        /// <remarks/>
        /// <summary>
        /// Airline official URL
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "airlineUrl", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string AirlineUrl { get; set; }

        /// <remarks/>
        /// <summary>
        /// Local departure date and time at starting airport of the segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "beginDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public System.DateTime BeginDate { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines the start locations of this segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "beginLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public Location BeginLocation { get; set; }

        /// <remarks/>
        /// <summary>
        /// The explicit aircraft name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "board", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string Board { get; set; }

        /// <remarks/>
        /// <summary>
        /// Holds a code for the aircraft type, if available. May not be available for every flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "boardCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string BoardCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// The first letter of the fare basis (see fareBasis below).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bookingClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string BookingClass { get; set; }

        /// <remarks/>
        /// <summary>
        /// Shows if this segment is connected to the previous segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "connected", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public bool Connected { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the context.
        /// A token that contains internal binary data that must be preserved for later usage in the booking process.
        /// <para>Within each flight object there is a so-called context which is important to be inserted in the following requests if referring to that flight.It is different for every flight and can not be switched between two differing flights.Since it is unique for a single flight, it can be cached along with the flight.</para>
        /// In the same way the context is used for <see cref="AirTicket"/>, <see cref="CostElement"/>, <see cref="FlightSegment"/>, <see cref="AeroexpressTrain"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "context", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 10)]
        public byte[] Context { get; set; }

        /// <remarks/>
        /// <summary>
        /// Local arrival date and time at the destination airport of the segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "endDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public System.DateTime EndDate { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines the end locations of this segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "endLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public Location EndLocation { get; set; }

        /// <remarks/>
        /// <summary>
        /// Tariff code, tariff name (example: LKLKDDF).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fareBasis", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string FareBasis { get; set; }

        /// <remarks/>
        /// <summary>
        /// The flight number of the segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "flightNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string FlightNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Luggage information is displayed depending on the carrier.Information is displayed as it was received from the carrier.
        /// <para>This list is not complete and final:</para>
        /// •0pc - no free baggage allowance
        /// <para>•Npc - number of pieces</para>
        /// •Nkg - max weight
        /// <para>•Npc x Nkg</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "luggageAllowed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string LuggageAllowed { get; set; }

        /// <remarks/>
        /// <summary>
        /// "Marketing carrier". The airline that gives its name to sell the ticket.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "marketingVendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public Vendor MarketingVendor { get; set; }

        /// <remarks/>
        /// <summary>
        /// The airline, operating this segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "operatingVendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public Vendor OperatingVendor { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of special service requests.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SSRs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 18)]
        public SSR[] SSRs { get; set; }

        /// <remarks/>
        /// <summary>
        /// Available seats on the flight. If 10 seats are offered, this means more than 9 seats are available (10 to airplane capacity).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "seats", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public int Seats { get; set; }

        /// <remarks/>
        /// <summary>
        /// The service class of the offered segment. It is allowed to use only uppercase letter.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public ServiceClass ServiceClass { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of technical stops. Info is returned from GDS in <see cref="SearchFlightsResponse"/> (see searchFlightsRS_stops).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("stops", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 21)]
        public TechnicalStop[] Stops { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines the terminal inside the airport at the begin of the segment. Return only parameter.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "terminalBegin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
        public string TerminalBegin { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines the terminal inside the airport at the end of the segment. Return only parameter.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "terminalEnd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 23)]
        public string TerminalEnd { get; set; }

        /// <remarks/>
        /// <summary>
        /// The duration in minutes for this segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "travelDuration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public int TravelDuration { get; set; }

        /// <remarks/>
        /// <summary>
        /// The vendor (usually the airline), offering this segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
        public Vendor Vendor { get; set; }
    }
}