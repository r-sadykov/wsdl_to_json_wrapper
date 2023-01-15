using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="CancelReservation"/> method to send the request for canceling the reservation.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "cancelReservation", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class CancelReservation
    {
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// The booking object, obtained from <see cref="CreateReservationResponse"/> that should be canceled.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "booking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelReservation"/> class.
        /// </summary>
        public CancelReservation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelReservation"/> class.
        /// </summary>
        /// <param name="agent">The agent information that issues a service.</param>
        /// <param name="booking">Booking object from previous requests.</param>
        public CancelReservation(BerlogicAgent agent, Booking booking)
        {
            this.Lang = agent.Lang;
            this.Booking = booking;
        }
    }
}