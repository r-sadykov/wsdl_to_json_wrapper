using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Agencies;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="GetBookingInfosFromReportDB"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getBookingInfosFromReportDB", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class GetBookingInfosFromReportDB
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
        /// Used to set parameters for the booking search.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 5)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "searchParameters", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BookingSearchParameter SearchParameters;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingInfosFromReportDB"/> class.
        /// </summary>
        public GetBookingInfosFromReportDB()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBookingInfosFromReportDB"/> class.
        /// </summary>
        /// <param name="agent">The agent information</param>
        /// <param name="searchParameters">parameters for the booking search.</param>
        public GetBookingInfosFromReportDB(BerlogicAgent agent, BookingSearchParameter searchParameters)
        {
            this.Lang = agent.Lang;
            this.AgencyCode = agent.AgencyCode;
            this.AgentCode = agent.AgentCode;
            this.SalesPoint = agent.SalesPoint;
            this.Password = agent.AgentPassword;
            this.SearchParameters = searchParameters;
        }
    }
}