using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Payment
{
    /// <summary>
    /// Used in the <see cref="PreparePayment"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "preparePayment", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class PreparePayment
    {
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// The booking object from <see cref="CreateReservationResponse"/>, possibly completed with fields that were optional in the <see cref="CreateReservation"/> phase.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "booking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="PreparePayment"/> class.
        /// </summary>
        public PreparePayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreparePayment"/> class.
        /// </summary>
        /// <param name="agent">The agent information.</param>
        /// <param name="booking">The booking object from <see cref="CreateReservationResponse"/>.</param>
        public PreparePayment(BerlogicAgent agent, Booking booking)
        {
            this.Lang = agent.Lang;
            this.Booking = booking;
        }
    }
}