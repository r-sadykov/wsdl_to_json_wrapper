using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Common
{
    /// <summary>
    /// Used in the <see cref="SendEmail"/> method to organize information to send via email to client.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "sendEmail", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SendEmail
    {
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// A booking object - the air ticket, for which the confirmation email with travel documents should be sent to the customer.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "booking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail"/> class.
        /// </summary>
        public SendEmail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail"/> class.
        /// </summary>
        /// <param name="agent">Represents the agent in BERlogic System, <see cref="BerlogicAgent"/></param>
        /// <param name="booking">A booking object - the air ticket, for which the confirmation email with travel documents should be sent to the customer</param>
        public SendEmail(BerlogicAgent agent, Booking booking)
        {
            this.Lang = agent.Lang;
            this.Booking = booking;
        }
    }
}