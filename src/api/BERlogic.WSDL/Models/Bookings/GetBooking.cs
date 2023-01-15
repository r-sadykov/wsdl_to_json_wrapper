using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Agencies;
using BERlogic.WSDL.Models.Airlines;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="GetBooking"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getBooking", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class GetBooking
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
        /// The booking ID in the database of web services, i.e only for internal use in system. Booking number is returned in <see cref="CreateReservationResponse"/>.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 5)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bookingNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BookingNumber;

        /// <summary>
        /// Set when you need the information from GDS in order to get some time for GDS connection. If not set, the status returned can be not synchronized with GDS state (taken as is from BERlogic database).
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 6)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeToWait", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long TimeToWait;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBooking"/> class.
        /// </summary>
        public GetBooking()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBooking"/> class.
        /// </summary>
        /// <param name="agent">The agent information.</param>
        /// <param name="bookingNumber">Booking ID in the database of web services.</param>
        /// <param name="timeToWait">Time for GDS connection.</param>
        public GetBooking(BerlogicAgent agent, string bookingNumber, long timeToWait)
        {
            this.Lang = agent.Lang;
            this.AgencyCode = agent.AgencyCode;
            this.AgentCode = agent.AgentCode;
            this.SalesPoint = agent.SalesPoint;
            this.Password = agent.AgentPassword;
            this.BookingNumber = bookingNumber;
            this.TimeToWait = timeToWait;
        }
    }
}