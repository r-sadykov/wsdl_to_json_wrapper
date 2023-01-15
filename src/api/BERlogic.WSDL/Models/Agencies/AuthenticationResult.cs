namespace BERlogic.WSDL.Models.Agencies
{
    /// <remarks/>
    /// <summary>
    /// Specifies the return data for <see cref="AuthenticateResponse"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class AuthenticationResult
    {
        /// <remarks/>
        /// <summary>
        /// The email address of the agent.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentEmail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string AgentEmail { get; set; }

        /// <remarks/>
        /// <summary>
        /// Hotel inventory system login if a partner has one.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentHotelLogin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AgentHotelLogin { get; set; }

        /// <remarks/>
        /// <summary>
        /// Hotel inventory system password if a partner has one.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentHotelPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AgentHotelPassword { get; set; }

        /// <remarks/>
        /// <summary>
        /// Agent's login for accessing the system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentLogin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string AgentLogin { get; set; }

        /// <remarks/>
        /// <summary>
        /// The explicit agent's name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string AgentName { get; set; }

        /// <remarks/>
        /// <summary>
        /// The phone number of the agent.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentTelephone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string AgentTelephone { get; set; }

        /// <remarks/>
        /// <summary>
        /// Agent TKP login. Valid only if an agent is TKP member.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentTkpLogin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string AgentTkpLogin { get; set; }

        /// <remarks/>
        /// <summary>
        /// Agent TKP password. Valid only if an agent is TKP member.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentTkpPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string AgentTkpPassword { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of allowed currencies for the agent.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("allowedCurrencies", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 8)]
        public string[] AllowedCurrencies { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of available sales points.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("availableSalesPoints", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public SalesPointExtended[] AvailableSalesPoints { get; set; }

        /// <remarks/>
        /// <summary>
        /// Indicates authentication success/failure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "successful", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public bool Successful { get; set; }
    }
}