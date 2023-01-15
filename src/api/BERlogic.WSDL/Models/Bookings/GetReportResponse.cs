using BERlogic.WSDL.Common;
using BERlogic.WSDL.Exceptions;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <summary>
    /// Used in the <see cref="GetReport"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getReportResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class GetReportResponse
    {
        /// <summary>
        /// А document or – in case of an error – a <see cref="ServiceException"/> or a <see cref="LocalizationException"/> or a <see cref="SecurityException"/>.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Document Document;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponse"/> class.
        /// </summary>
        public GetReportResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponse"/> class.
        /// </summary>
        /// <param name="document">The document that was formed in response.</param>
        public GetReportResponse(Document document)
        {
            this.Document = document;
        }
    }
}