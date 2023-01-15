namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <summary>
    /// Used in the <see cref="SearchAeroexpressTrainInfo"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchAeroexpressTrainInfo", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchAeroexpressTrainInfo
    {
        /// <summary>
        /// Several parameters that adapt the search request to the user's wishes.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(elementName: "settings", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AeroexpressTrainSearchSettings Settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressTrainInfo"/> class.
        /// </summary>
        public SearchAeroexpressTrainInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressTrainInfo"/> class.
        /// </summary>
        /// <param name="settings">Parameters that filter desirable by Client list of AeroExpress services.</param>
        public SearchAeroexpressTrainInfo(AeroexpressTrainSearchSettings settings)
        {
            this.Settings = settings;
        }
    }
}