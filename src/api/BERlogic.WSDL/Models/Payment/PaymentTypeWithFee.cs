using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Airlines;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// A fee per payment type. Can be used generally to describe allowed payment types in some other types, such as <see cref="Flight"/> and <see cref="AeroexpressTrain"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class PaymentTypeWithFee
    {
        /// <remarks/>
        /// <summary>
        /// Amount is returned in <see cref="SearchFlightsResponse"/>. Can be set as fixed amount as well as percentage and also can take negative value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fee", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public decimal Fee { get; set; }

        /// <remarks/>
        /// <summary>
        /// The currency in which this fee is represented. Supported: EUR, RUB.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "feeCurrency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string FeeCurrency { get; set; }

        /// <remarks/>
        /// <summary>
        /// Payment type that could be used by client.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public PaymentType Type { get; set; }
    }
}