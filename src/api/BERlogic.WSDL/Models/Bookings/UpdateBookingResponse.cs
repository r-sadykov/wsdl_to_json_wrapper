using BERlogic.WSDL.Exceptions;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="UpdateBooking"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "updateBookingResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class UpdateBookingResponse
    {
        /// <summary>
        /// А booking object or – in case of an error – a <see cref="ServiceException"/> or a <see cref="LocalizationException"/> or a security exception
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBookingResponse"/> class.
        /// </summary>
        public UpdateBookingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBookingResponse"/> class.
        /// </summary>
        /// <param name="booking">А booking object.</param>
        public UpdateBookingResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}