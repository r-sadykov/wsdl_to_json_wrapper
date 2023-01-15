using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Bookings;
using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="FinishBooking"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "finishBooking", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class FinishBooking
    {
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// The booking object from <see cref="CreateReservationResponse"/> or <see cref="PreparePaymentResponse"/>, possibly completed with fields that were optional in the <see cref="CreateReservation"/> phase.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "booking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// The basic contructor to initialize object <see cref="FinishBooking"/> with data by default.
        /// </summary>
        public FinishBooking()
        {
        }

        /// <summary>
        /// The extented contructor to initialize object <see cref="FinishBooking"/> with data passed through parameter.
        /// </summary>
        /// <param name="agent">The agent information that issue service.</param>
        /// <param name="booking">The booking object.</param>
        public FinishBooking(BerlogicAgent agent, Booking booking)
        {
            this.Lang = agent.Lang;
            this.Booking = booking;
        }
    }
}