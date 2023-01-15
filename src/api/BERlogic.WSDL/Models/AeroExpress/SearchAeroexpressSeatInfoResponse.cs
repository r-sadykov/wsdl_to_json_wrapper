namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <summary>
    /// The search aeroexpress seat info response.
    /// Used in the <see cref="SearchAeroexpressSeatInfo"/> method to get the response with available free seats on the chosen train.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchAeroexpressSeatInfoResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchAeroexpressSeatInfoResponse
    {
        /// <summary>
        /// A list of available seats at Aeroexpress trains or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AeroexpressSeatInfo[] AeroexpressSeatInfos;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressSeatInfoResponse"/> class.
        /// </summary>
        public SearchAeroexpressSeatInfoResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAeroexpressSeatInfoResponse"/> class.
        /// </summary>
        /// <param name="aeroexpressSeatInfos">The array <see cref="AeroexpressSeatInfo"/> with information about available free seats on AeroExpress train..</param>
        public SearchAeroexpressSeatInfoResponse(AeroexpressSeatInfo[] aeroexpressSeatInfos)
        {
            this.AeroexpressSeatInfos = aeroexpressSeatInfos;
        }
    }
}