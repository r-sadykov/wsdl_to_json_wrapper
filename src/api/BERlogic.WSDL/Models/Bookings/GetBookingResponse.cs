namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="GetBooking"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getBookingResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class GetBookingResponse
    {
        /// <summary>
        /// А booking object or – in case of an error – a serviceException or a localizationException or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingResponse"/> class.
        /// </summary>
        public GetBookingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingResponse"/> class.
        /// </summary>
        /// <param name="booking">А booking object.</param>
        public GetBookingResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}