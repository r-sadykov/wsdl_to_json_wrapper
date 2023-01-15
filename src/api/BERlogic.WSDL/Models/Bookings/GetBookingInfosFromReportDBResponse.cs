namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="GetBookingInfosFromReportDB"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getBookingInfosFromReportDBResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class GetBookingInfosFromReportDBResponse
    {
        /// <summary>
        /// А list of booking objects with basic information on each of them or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OutlineBooking[] OutlineBookings;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingInfosFromReportDBResponse"/> class.
        /// </summary>
        public GetBookingInfosFromReportDBResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingInfosFromReportDBResponse"/> class.
        /// </summary>
        /// <param name="outlineBookings">А list of booking objects with basic information on each of them.</param>
        public GetBookingInfosFromReportDBResponse(OutlineBooking[] outlineBookings)
        {
            this.OutlineBookings = outlineBookings;
        }
    }
}