namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="SearchRemarks"/> method to get information about fare conditions for the air ticket.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchRemarksResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchRemarksResponse
    {
        /// <summary>
        /// The full text of fare conditions. In case of several vendors or/and several fares on flight segments this text contains conditions for all of them. In case of an error - an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SearchRemarks;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRemarksResponse"/> class.
        /// </summary>
        public SearchRemarksResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRemarksResponse"/> class.
        /// </summary>
        /// <param name="searchRemarks">The full text of fare conditions represents in <see cref="SearchRemarks"/></param>
        public SearchRemarksResponse(string searchRemarks)
        {
            this.SearchRemarks = searchRemarks;
        }
    }
}