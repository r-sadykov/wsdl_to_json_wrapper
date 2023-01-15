namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// The lastschrift - model of payment that uses in Germany.
    /// Direct debit (Lastschrift) account details for payment.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Lastschrift
    {
        /// <remarks/>
        /// <summary>
        /// The name of the bank.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bank", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Bank { get; set; }

        /// <remarks/>
        /// <summary>
        /// Bank Identifier Code (BIC).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bic", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string BIC { get; set; }

        /// <remarks/>
        /// <summary>
        /// The International Bank Account Number (IBAN).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "iban", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string IBAN { get; set; }

        /// <summary>
        /// The name of the account holder.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "owner", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string Owner { get; set; }
    }
}