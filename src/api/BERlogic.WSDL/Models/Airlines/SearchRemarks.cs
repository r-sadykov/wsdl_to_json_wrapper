using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="SearchRemarks"/> method to send the request to obtain full text of fare conditions.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchRemarks", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchRemarks
    {
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// A booking object - the air ticket, for which fare conditions should be obtained.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "airticket", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Airticket;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRemarks"/> class.
        /// </summary>
        public SearchRemarks()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRemarks"/> class.
        /// </summary>
        /// <param name="agent">Represents the agent in BERlogic System, <see cref="BerlogicAgent"/></param>
        /// <param name="airticket">A booking object - the air ticket, for which the confirmation email with travel documents should be sent to the customer</param>
        public SearchRemarks(BerlogicAgent agent, Booking airticket)
        {
            this.Lang = agent.Lang;
            this.Airticket = airticket;
        }
    }
}