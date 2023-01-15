using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="CheckPricing"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "checkPricingResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class CheckPricingResponse
    {
        /// <summary>
        /// А booking object (same object structure as also used for the request) or – in case of an error – an exception or a security exception. The returned booking object may be unchanged or changed, i.e. with an updated price. The web service client logic needs to check for these results and possible changes to react adequately for further proceedings and to give correct information to the end user.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPricingResponse"/> class.
        /// </summary>
        public CheckPricingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPricingResponse"/> class.
        /// </summary>
        /// <param name="booking">Booking object that was received in previous requests.</param>
        public CheckPricingResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}