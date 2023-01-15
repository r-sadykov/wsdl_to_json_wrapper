namespace BERlogic.WSDL.Models.Agencies
{
    /// <summary>
    /// Used in the <see cref="ChangePassword"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "changePasswordResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class ChangePasswordResponse
    {
        /// <summary>
        /// The new assigned password for the agent or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordResponse"/> class.
        /// </summary>
        public ChangePasswordResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordResponse"/> class.
        /// </summary>
        /// <param name="result">The new assigned password for the agent.</param>
        public ChangePasswordResponse(string result)
        {
            this.Result = result;
        }
    }
}