using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Models.Insurance
{
    /// <summary>
    /// Used in the <see cref="CalculateInsurance"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "calculateInsuranceResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class CalculateInsuranceResponse
    {
        /// <summary>
        /// The calculated cost of the insurance policy or – in case of an error – a service exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Money Money;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateInsuranceResponse"/> class.
        /// </summary>
        public CalculateInsuranceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateInsuranceResponse"/> class.
        /// </summary>
        /// <param name="money">The calculated cost of the insurance policy.</param>
        public CalculateInsuranceResponse(Money money)
        {
            this.Money = money;
        }
    }
}