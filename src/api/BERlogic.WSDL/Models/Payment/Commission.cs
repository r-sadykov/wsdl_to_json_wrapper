using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// The commission.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Commission
    {
        /// <remarks/>
        /// <summary>
        /// Amount of commission.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public decimal Amount { get; set; }

        /// <remarks/>
        /// <summary>
        /// The type of commission.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Type Type { get; set; }
    }
}