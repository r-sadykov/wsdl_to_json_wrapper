namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <summary>
    /// Used in the <see cref="SearchAeroexpressTrainInfo"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchAeroexpressTrainInfoResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchAeroexpressTrainInfoResponse
    {
        /// <summary>
        /// А list of AeroExpress trains or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AeroexpressTrain[] AeroexpressTrains;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressTrainInfoResponse"/> class.
        /// </summary>
        public SearchAeroexpressTrainInfoResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressTrainInfoResponse"/> class.
        /// </summary>
        /// <param name="aeroexpressTrains">The array of available trains in AeroExpress</param>
        public SearchAeroexpressTrainInfoResponse(AeroexpressTrain[] aeroexpressTrains)
        {
            this.AeroexpressTrains = aeroexpressTrains;
        }
    }
}