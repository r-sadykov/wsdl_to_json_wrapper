namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="SearchFlights"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchFlightsResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchFlightsResponse
    {
        /// <summary>
        /// A list of flights or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Flight[] Flights;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFlightsResponse"/> class.
        /// </summary>
        public SearchFlightsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFlightsResponse"/> class.
        /// </summary>
        /// <param name="flights"> List of available flights</param>
        public SearchFlightsResponse(Flight[] flights)
        {
            this.Flights = flights;
        }
    }
}