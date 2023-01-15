using Phaenir.Common.Models;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// Credit card details for <see cref="Payment"/> and preparePayment_AviaTiny.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class CreditCard : ICreditCard
    {
        /// <remarks/>
        /// <summary>
        /// The CVC number of the credit card.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cvc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string CVC { get; set; }

        /// <remarks/>
        /// <summary>
        /// The expiry date of the credit card.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expired", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public System.DateTime Expired { get; set; }

        /// <remarks/>
        /// <summary>
        /// Credit card number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "number", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Number { get; set; }

        /// <remarks/>
        /// <summary>
        /// The name of the owner of the credit card, as printed on the card (usually "Firstname Lastname").
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "owner", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string Owner { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the SCA.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "sca", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public StrongCustomerAuth SCA { get; set; }

        /// <remarks/>
        /// <summary>
        /// The credit card vendor.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public CreditCardVendor Vendor { get; set; }
    }
}