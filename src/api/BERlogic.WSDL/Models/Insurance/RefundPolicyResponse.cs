using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Insurance
{
    /// <summary>
    /// Used in the <see cref="RefundPolicy"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "refundPolicyResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class RefundPolicyResponse
    {
        /// <summary>
        /// A booking object, for which the insurance policy should be refunded manually, or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPolicyResponse"/> class.
        /// </summary>
        public RefundPolicyResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPolicyResponse"/> class.
        /// </summary>
        /// <param name="booking">A booking object, for which the insurance policy should be refunded manually.</param>
        public RefundPolicyResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}