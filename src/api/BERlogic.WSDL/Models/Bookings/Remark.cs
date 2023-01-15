namespace BERlogic.WSDL.Models.Bookings
{
    /// <remarks/>
    /// <summary>
    /// GDS remarks in <see cref="BookingBase"/> that were read for the booking and can be sent to a partner (as received from GDS).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Remark
    {
        /// <remarks/>
        /// <summary>
        /// Composition of details could be different inside remarks.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "details", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public RemarkDetails Details { get; set; }

        /// <remarks/>
        /// <summary>
        /// Could be multiple. It depends on information from specific GDS.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("text", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public string[] Text { get; set; }
    }
}