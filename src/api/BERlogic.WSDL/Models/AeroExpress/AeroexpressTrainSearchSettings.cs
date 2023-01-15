using BERlogic.WSDL.Common;

namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <remarks/>
    /// <summary>
    /// Several parameters that adapt the search request to the user's wishes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class AeroexpressTrainSearchSettings
    {
        /// <summary>
        /// The basic contructor to initialize object <see cref="AeroexpressTrainSearchSettings"/> with data by default.
        /// </summary>
        public AeroexpressTrainSearchSettings() { }

        /// <summary>
        /// The extented contructor to initialize object <see cref="AeroexpressTrainSearchSettings"/> with data passed through parameter.
        /// </summary>
        /// <param name="agent">Agent data who make order of this service.</param>
        public AeroexpressTrainSearchSettings(BerlogicAgent agent)
        {
            AgencyCode = agent.AgencyCode;
            AgentCode = agent.AgentCode;
            AgentPassword = agent.AgentPassword;
            Lang = agent.Lang;
            PreferredCurrency = agent.PreferredCurrency;
            SalesPoint = agent.SalesPoint.Code;
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
        /// The currency in which this ticket is offered and prices are represented. Supported: EUR, RUB.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "preferredCurrency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string PreferredCurrency { get; set; }

        /// <remarks/>
        /// <summary>
        /// Salespoint information from wich all services orders made.
        /// One of the authentication parameters. Code of the salespoint that belongs to the agency created in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string SalesPoint { get; set; }
    }
}