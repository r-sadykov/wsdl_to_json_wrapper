using BERlogic.WSDL.Exceptions;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="ImportBooking"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importBookingResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class ImportBookingResponse
    {
        /// <summary>
        /// А booking object or – in case of an error – a <see cref="ServiceException"/> or a <see cref="LocalizationException"/> or a <see cref="SecurityException"/>.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBookingResponse"/> class.
        /// </summary>
        public ImportBookingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBookingResponse"/> class.
        /// </summary>
        /// <param name="booking">А booking object.</param>
        public ImportBookingResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}