using BERlogic.WSDL.Common;
using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="SearchSchedule"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchSchedule", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchSchedule
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
        /// Code of the salespoint that belongs to the agency created in  in the BERlogic system for partner's connection.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 3)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPointCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SalesPointCode;

        /// <summary>
        /// The airport or city code of the starting point.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 4)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "beginLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BeginLocation;

        /// <summary>
        /// The airport or city code of the end point
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 5)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "endLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EndLocation;

        /// <summary>
        /// The departure date.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 6)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "periodBegin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime PeriodBegin;

        /// <summary>
        /// The arrival date.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 7)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "periodEnd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime PeriodEnd;

        /// <summary>
        /// Available service class on the board
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 8)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceClass ServiceClass;

        /// <summary>
        /// The IATA code of airline.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 9)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "airlineCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AirlineCode;

        /// <summary>
        /// If true, only direct flights will be returned.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 10)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "directOnly", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool DirectOnly;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSchedule"/> class.
        /// </summary>
        public SearchSchedule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSchedule"/> class.
        /// </summary>
        /// <param name="agent">The agent information.</param>
        /// <param name="beginLocation">The begin location.</param>
        /// <param name="endLocation">The end location.</param>
        /// <param name="periodBegin">Departure date.</param>
        /// <param name="periodEnd">Arrival date.</param>
        /// <param name="serviceClass">The service class on the board.</param>
        /// <param name="airlineCode">The airline code.</param>
        /// <param name="directOnly">If true, direct only.</param>
        public SearchSchedule(BerlogicAgent agent, string beginLocation, string endLocation, System.DateTime periodBegin, System.DateTime periodEnd, ServiceClass serviceClass, string airlineCode, bool directOnly)
        {
            this.AgencyCode = agent.AgencyCode;
            this.AgentCode = agent.AgentCode;
            this.AgentPassword = agent.AgentPassword;
            this.SalesPointCode = agent.SalesPoint.Code;
            this.BeginLocation = beginLocation;
            this.EndLocation = endLocation;
            this.PeriodBegin = periodBegin;
            this.PeriodEnd = periodEnd;
            this.ServiceClass = serviceClass;
            this.AirlineCode = airlineCode;
            this.DirectOnly = directOnly;
        }
    }
}