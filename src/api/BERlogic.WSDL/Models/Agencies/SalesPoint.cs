namespace BERlogic.WSDL.Models.Agencies
{
    /// <remarks/>
    /// <summary>
    /// The sales point that used in System to point to exact place of sales.
    /// Contains information about a sales point.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SalesPointExtended))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class SalesPoint
    {
        /// <remarks/>
        /// <summary>
        /// Code of the salespoint that belongs to the agency created in  in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "code", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Code { get; set; }

        /// <remarks/>
        /// <summary>
        /// The explicit sales point name. Output parameter, no input required.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Name { get; set; }

        /// <remarks/>
        /// <summary>
        /// The time zone of the sales point. Output parameter, no input required.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeZone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string TimeZone { get; set; }
    }
}