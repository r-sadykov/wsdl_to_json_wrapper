using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Agencies;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="ImportBooking"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importBooking", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class ImportBooking
    {
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgencyCode;

        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 2)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgentCode;

        /// <summary>
        /// Salespoint information from wich all services orders made.
        /// Code of the salespoint that belongs to the agency created in the BERlogic system for partner's connection.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 3)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SalesPoint SalesPoint;

        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 4)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Password;

        /// <summary>
        /// Channel ID in the BERlogic system. Mandatory. Request your account manager for your IDs.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 5)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "gdsId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GdsId;

        /// <summary>
        /// Passenger Name Record. Mandatory.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 6)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pnr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PNR;

        /// <summary>
        /// Last name (family name) of the passenger. Mandatory for requests to Sirena.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 7)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "surname", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Surname;

        /// <summary>
        /// If true, than we required forced update
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 8)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "forceUpdate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ForceUpdate;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBooking"/> class.
        /// </summary>
        public ImportBooking()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBooking"/> class.
        /// </summary>
        /// <param name="agent">The agent information.</param>
        /// <param name="gdsId">The gds or channel id.</param>
        /// <param name="pnr">Passenger Name Record.</param>
        /// <param name="surname">Passenger's last name.</param>
        /// <param name="forceUpdate">If true, force update.</param>
        public ImportBooking(BerlogicAgent agent, string gdsId, string pnr, string surname, bool forceUpdate)
        {
            this.Lang = agent.Lang;
            this.AgencyCode = agent.AgencyCode;
            this.AgentCode = agent.AgentCode;
            this.SalesPoint = agent.SalesPoint;
            this.Password = agent.AgentPassword;
            this.GdsId = gdsId;
            this.PNR = pnr;
            this.Surname = surname;
            this.ForceUpdate = forceUpdate;
        }
    }
}