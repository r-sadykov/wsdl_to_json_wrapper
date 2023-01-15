using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="FinishBooking"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "finishBookingResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class FinishBookingResponse
    {
        /// <summary>
        /// А booking object (same object structure as also used for the request) or – in case of an error – an exception or a security exception. The returned booking object is changed, for example, through receiving documents, log items, etc.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// The basic contructor to initialize object <see cref="FinishBookingResponse"/> with data by default.
        /// </summary>
        public FinishBookingResponse()
        {
        }

        /// <summary>
        /// The extented contructor to initialize object <see cref="FinishBookingResponse"/> with data passed through parameter.
        /// </summary>
        /// <param name="booking">А booking object (same object structure as also used for the request).</param>
        public FinishBookingResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}