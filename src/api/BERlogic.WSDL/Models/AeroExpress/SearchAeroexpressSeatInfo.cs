using BERlogic.WSDL.Common;

namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <summary>
    /// Used in the <see cref="SearchAeroexpressSeatInfo"/> method to send the request to get a array of available seats on train.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchAeroexpressSeatInfo", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchAeroexpressSeatInfo
    {
        /// <summary>
        /// Identification number of chosen food in menu in train's restaurant
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "menuId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int MenuId;

        /// <summary>
        /// The date and time of the trip.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime Date;

        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 2)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "language", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Language;

        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 3)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgencyCode;

        /// <summary>
        /// Salespoint information from wich all services orders made.
        /// One of the authentication parameters. Code of the salespoint that belongs to the agency created in the BERlogic system for partner's connection.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 4)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPointCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SalesPointCode;

        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 5)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgentCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressSeatInfo"/> class.
        /// </summary>
        public SearchAeroexpressSeatInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressSeatInfo"/> class.
        /// </summary>
        /// <param name="menuId">Food ID in train's restaurant menu.</param>
        /// <param name="date">Date and Time of trip.</param>
        /// <param name="agent">Agent data who make order of this service.</param>
        public SearchAeroexpressSeatInfo(int menuId, System.DateTime date, BerlogicAgent agent)
        {
            this.MenuId = menuId;
            this.Date = date;
            this.Language = agent.Lang;
            this.AgencyCode = agent.AgencyCode;
            this.SalesPointCode = agent.SalesPoint.Code;
            this.AgentCode = agent.AgentCode;
        }
    }
}