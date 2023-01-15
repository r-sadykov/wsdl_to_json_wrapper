namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// The response from BERlogic service after update passenger information.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "updatePassengerResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class UpdatePassengerResponse
    {
        /// <summary>
        /// Result of update of passenger information
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UpdatePassengerResult Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePassengerResponse"/> class.
        /// </summary>
        public UpdatePassengerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePassengerResponse"/> class.
        /// </summary>
        /// <param name="result">Result of update of passenger information.</param>
        public UpdatePassengerResponse(UpdatePassengerResult result)
        {
            this.Result = result;
        }
    }
}