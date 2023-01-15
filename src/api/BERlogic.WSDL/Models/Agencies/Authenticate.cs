using BERlogic.WSDL.Common;

namespace BERlogic.WSDL.Models.Agencies
{
    /// <summary>
    /// Used in the <see cref="Authenticate"/> method to send the authorization request.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "authenticate", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class Authenticate
    {
        /// <summary>
        /// Agent's login for accessing the system.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgentCode;

        /// <summary>
        /// The assigned password for the agent.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Password;

        /// <summary>
        /// The basic contructor to initialize object <see cref="Authenticate"/> with data by default.
        /// </summary>
        public Authenticate()
        {
        }

        /// <summary>
        /// The extented contructor to initialize object <see cref="Authenticate"/> with data passed through parameter.
        /// </summary>
        /// <param name="agent">The agent information.</param>
        /// <param name="password">The agent's password.</param>
        public Authenticate(BerlogicAgent agent, string password)
        {
            this.AgentCode = agent.AgentCode;
            this.Password = password;
        }
    }
}