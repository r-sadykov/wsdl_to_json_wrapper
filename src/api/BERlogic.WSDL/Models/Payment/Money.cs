using BERlogic.WSDL.Models.Insurance;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// Used in SPZDTicket and in <see cref="CalculateInsuranceResponse"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Money
    {
        /// <remarks/>
        /// <summary>
        /// Cost for service
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public double Amount { get; set; }

        /// <remarks/>
        /// <summary>
        /// Cost for service in base currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "baseAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public double BaseAmount { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the base currency.
        /// Supported: EUR, RUB.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "baseCurrency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Currency BaseCurrency { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// Supported: EUR, RUB.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "currency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// Exchange rate value.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "exchangeRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public double ExchangeRate { get; set; }
    }
}