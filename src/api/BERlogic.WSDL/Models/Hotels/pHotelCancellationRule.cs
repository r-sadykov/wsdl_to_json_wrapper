namespace BERlogic.WSDL.Models.Hotels
{
    /// <remarks/>
    /// <summary>
    /// Information about cancellation rules that represented in <see cref="pHotelRoom"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class pHotelCancellationRule
    {
        /// <remarks/>
        /// <summary>
        /// Amount of compensation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public pPrice Amount { get; set; }

        /// <remarks/>
        /// <summary>
        /// If true, cancellation is possible.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "possible", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public bool Possible { get; set; }

        /// <remarks/>
        /// <summary>
        /// The date and time from which the cancellation is possible.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "utcDateFrom", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public System.DateTime UtcDateFrom { get; set; }

        /// <remarks/>
        /// <summary>
        /// The date and time until which the cancellations is possible.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "utcDateTo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public System.DateTime UtcDateTo { get; set; }
    }
}