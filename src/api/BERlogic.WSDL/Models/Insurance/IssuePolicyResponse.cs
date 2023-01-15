using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Insurance
{
    /// <summary>
    /// Used in the <see cref="IssuePolicy"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "issuePolicyResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class IssuePolicyResponse
    {
        /// <summary>
        /// A booking object, for which the insurance policy should be issued manually, or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuePolicyResponse"/> class.
        /// </summary>
        public IssuePolicyResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuePolicyResponse"/> class.
        /// </summary>
        /// <param name="booking">A booking object.</param>
        public IssuePolicyResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}