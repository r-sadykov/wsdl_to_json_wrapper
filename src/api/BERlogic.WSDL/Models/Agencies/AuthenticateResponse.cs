namespace BERlogic.WSDL.Models.Agencies
{
    /// <summary>
    /// Used in the <see cref="Authenticate"/>authenticate method to get the authorization response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "authenticateResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class AuthenticateResponse
    {
        /// <summary>
        /// Authorization data or – in case of an error – a service or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "authenticationResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AuthenticationResult Authentication;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateResponse"/> class.
        /// </summary>
        public AuthenticateResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateResponse"/> class.
        /// </summary>
        /// <param name="authentication">The authentication result.</param>
        public AuthenticateResponse(AuthenticationResult authentication)
        {
            this.Authentication = authentication;
        }
    }
}