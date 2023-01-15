using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Payment
{
    /// <summary>
    /// Used in the <see cref="PreparePayment"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "preparePaymentResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class PreparePaymentResponse
    {
        /// <summary>
        /// А booking object (same object structure as also used for the request) or – in case of an error – an exception or a security exception or a service exception. The returned booking object is changed, for example, through receiving payment information, etc.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="PreparePaymentResponse"/> class.
        /// </summary>
        public PreparePaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreparePaymentResponse"/> class.
        /// </summary>
        /// <param name="booking">А booking object (same object structure as also used for the request).</param>
        public PreparePaymentResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}