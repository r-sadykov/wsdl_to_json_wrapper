namespace BERlogic.WSDL.Models.Passengers
{
    /// <remarks/>
    /// <summary>
    /// The passenger entry in airline reservation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class PassengerEntry
    {
        /// <remarks/>
        /// <summary>
        /// Key as a category of growing up.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "key", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Key { get; set; }

        /// <remarks/>
        /// <summary>
        /// Amount of passenger(s) in same adult category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "value", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Value { get; set; }
    }
}