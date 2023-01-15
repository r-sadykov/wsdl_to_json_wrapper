using BERlogic.WSDL.Common;

namespace BERlogic.WSDL.Models.Agencies
{
    /// <summary>
    /// Used in the <see cref="ChangePassword"/> method to send the request for change the authorization password for an agent.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "changePassword", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class ChangePassword
    {
        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AgentCode;

        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Password;

        /// <summary>
        /// The new assigned password for the agent.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 2)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "newPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NewPassword;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePassword"/> class.
        /// </summary>
        public ChangePassword()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePassword"/> class.
        /// </summary>
        /// <param name="agent">The agent information that allowed to make requests into BERlogic's services.</param>
        /// <param name="newPassword">The new password for Agent.</param>
        public ChangePassword(BerlogicAgent agent, string newPassword)
        {
            this.AgentCode = agent.AgentCode;
            this.Password = agent.AgentPassword;
            this.NewPassword = newPassword;
        }
    }
}