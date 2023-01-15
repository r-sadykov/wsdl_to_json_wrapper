namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="SearchFlights"/> method to send the request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchFlights", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchFlights
    {
        /// <summary>
        /// Several parameters that adapt the search request to the user's wishes.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "settings", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FlightSearchSettings Settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFlights"/> class.
        /// </summary>
        public SearchFlights()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFlights"/> class.
        /// </summary>
        /// <param name="settings">Several parameters that adapt the search request to the user's wishes.</param>
        public SearchFlights(FlightSearchSettings settings)
        {
            this.Settings = settings;
        }
    }
}