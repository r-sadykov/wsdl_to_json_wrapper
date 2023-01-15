namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Used to describe technical stops in <see cref="FlightSegment"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class TechnicalStop
    {
        /// <remarks/>
        /// <summary>
        /// Local departure time at starting airport of the technical stop.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "begin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public System.DateTime Begin { get; set; }

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
        /// Local arrival time at the destination airport of the technical stop.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "end", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public System.DateTime End { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines the locations of this technical stop.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "location", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public Location Location { get; set; }
    }
}