using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Insurance
{
    /// <summary>
    /// Used in the <see cref="ReversePolicy"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "reversePolicyResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class ReversePolicyResponse
    {
        /// <summary>
        /// A booking object, for which the insurance policy should be cancelled manually, or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversePolicyResponse"/> class.
        /// </summary>
        public ReversePolicyResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversePolicyResponse"/> class.
        /// </summary>
        /// <param name="booking"> A booking object, for which the insurance policy should be cancelled manually.</param>
        public ReversePolicyResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}