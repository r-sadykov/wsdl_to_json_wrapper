namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Defines one leg (or direction) of a flight in <see cref="FlightSearchSettings"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class RouteSegment
    {
        /// <remarks/>
        /// <summary>
        /// The airport or city code of the starting point of the segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "beginLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string BeginLocation { get; set; }

        /// <remarks/>
        /// <summary>
        /// The date of the departure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public System.DateTime Date { get; set; }

        /// <remarks/>
        /// <summary>
        /// Departure time.
        /// hh:mm
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "departureTimeFrom", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string DepartureTimeFrom { get; set; }

        /// <remarks/>
        /// <summary>
        /// Arrival time.
        /// hh:mm
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "departureTimeTo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string DepartureTimeTo { get; set; }

        /// <remarks/>
        /// <summary>
        /// The airport or city code of the end point of the segment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "endLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string EndLocation { get; set; }
    }
}