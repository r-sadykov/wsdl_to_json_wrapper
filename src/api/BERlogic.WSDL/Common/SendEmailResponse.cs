using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Common
{
    /// <summary>
    /// Used in the <see cref="SendEmail"/> method to get the response for sending to the customer the confirmation email with travel documents.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "sendEmailResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SendEmailResponse
    {
        /// <summary>
        /// А booking object (same object structure as also used for the request) or – in case of an error – an exception or a security exception. The returned booking object may be unchanged or changed.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailResponse"/> class.
        /// </summary>
        public SendEmailResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailResponse"/> class.
        /// </summary>
        /// <param name="booking">Booking object as <see cref="Booking"/> that we receive during service order procedure.</param>
        public SendEmailResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}