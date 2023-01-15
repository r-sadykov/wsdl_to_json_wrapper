namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// The сost of changes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class CostOfChanges
    {
        /// <remarks/>
        /// <summary>
        /// Total cost for changes in services.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "total", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Money Total { get; set; }
    }
}