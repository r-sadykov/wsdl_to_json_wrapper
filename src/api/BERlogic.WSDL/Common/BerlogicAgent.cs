using BERlogic.WSDL.Models.Agencies;

namespace BERlogic.WSDL.Common
{
    /// <summary>
    /// Represents the agent in BERlogic System
    /// </summary>
    public class BerlogicAgent
    {
        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        public string AgencyCode { get; set; }

        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        public string AgentPassword { get; set; }

        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// The currency in which this flight is offered and prices are represented. Supported: EUR, RUB.
        /// </summary>
        public string PreferredCurrency { get; set; }

        /// <summary>
        /// Salespoint information from wich all services orders made.
        /// One of the authentication parameters. Code of the salespoint that belongs to the agency created in the BERlogic system for partner's connection.
        /// </summary>
        public SalesPoint SalesPoint { get; set; }
    }
}