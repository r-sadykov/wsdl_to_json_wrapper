using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="CreateReservation"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "createReservationResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class CreateReservationResponse
    {
        /// <summary>
        /// А booking object (same object structure as also used for the request) or – in case of an error – an exception or a security exception. The returned booking object is changed, for example, through receiving the booking number, etc.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReservationResponse"/> class.
        /// </summary>
        public CreateReservationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReservationResponse"/> class.
        /// </summary>
        /// <param name="booking">The booking object.</param>
        public CreateReservationResponse(Booking booking)
        {
            this.Booking = booking;
        }
    }
}