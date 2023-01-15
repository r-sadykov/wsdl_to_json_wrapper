using BERlogic.WSDL.Common;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// The void tickets.
    /// Used in the <see cref="VoidTickets"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "voidTickets", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class VoidTickets
    {
        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgencyCode;

        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgentCode;

        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 2)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgentPassword;

        /// <summary>
        /// SalesPointCode
        /// One of the authentication parameters. Code of the salespoint that belongs to the agency created in  in the BERlogic system for partner's connection
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 3)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPointCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SalesPointCode;

        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 4)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// The booking ID in the database of web services, i.e only for internal use in BERlogic system. Booking number is returned in <see cref="CreateReservationResponse"/>.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 5)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bookingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BookingNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidTickets"/> class.
        /// </summary>
        public VoidTickets()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidTickets"/> class.
        /// </summary>
        /// <param name="agent">The agent information.</param>
        /// <param name="bookingNumber">The booking number.</param>
        public VoidTickets(BerlogicAgent agent, string bookingNumber)
        {
            this.AgencyCode = agent.AgencyCode;
            this.AgentCode = agent.AgentCode;
            this.AgentPassword = agent.AgentPassword;
            this.SalesPointCode = agent.SalesPoint.Code;
            this.Lang = agent.Lang;
            this.BookingNumber = bookingNumber;
        }
    }
}