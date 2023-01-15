using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Category of passenger(s) and their amount in booking order.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class FlightSearchSettingsEntry
    {
        /// <remarks/>
        /// <summary>
        /// Passenger's category
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "key", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public PassengerCategory Key { get; set; }

        /// <remarks/>
        /// <summary>
        /// The amount of passenger in one category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "value", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public int Value { get; set; }
    }
}