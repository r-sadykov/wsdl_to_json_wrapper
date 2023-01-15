using BERlogic.WSDL.Common;
using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Passengers;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// The passenger settings for update information about him.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class UpdatePassengerSettings
    {
        /// <summary>
        /// Initialize passenger settings for update.
        /// </summary>
        public UpdatePassengerSettings() { }

        /// <summary>
        /// Initialize passenger settings for update.
        /// </summary>
        /// <param name="agent">Information about agent</param>
        public UpdatePassengerSettings(BerlogicAgent agent)
        {
            AgencyCode = agent.AgencyCode;
            AgentCode = agent.AgentCode;
            AgentPassword = agent.AgentPassword;
            Lang = agent.Lang;
            SalesPointCode = agent.SalesPoint.Code;
        }

        /// <remarks/>
        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string AgencyCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AgentCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AgentPassword { get; set; }

        /// <remarks/>
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string Lang { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of passengers.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("passengers", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public Passenger[] Passengers { get; set; }

        /// <remarks/>
        /// <summary>
        /// Record locator.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "recordLocator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string RecordLocator { get; set; }

        /// <remarks/>
        /// <summary>
        /// Request type.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "requestType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public RequestType RequestType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Sales point code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPointCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string SalesPointCode { get; set; }
    }
}