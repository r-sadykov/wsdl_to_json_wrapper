namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="GetBookings"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getBookingsResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class GetBookingsResponse
    {
        /// <summary>
        /// А list of booking objects or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking[] Bookings;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingsResponse"/> class.
        /// </summary>
        public GetBookingsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingsResponse"/> class.
        /// </summary>
        /// <param name="bookings">А list of booking objects.</param>
        public GetBookingsResponse(Booking[] bookings)
        {
            this.Bookings = bookings;
        }
    }
}