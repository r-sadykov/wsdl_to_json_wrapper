namespace BERlogic.WSDL.Exceptions
{
    /// <remarks/>
    /// <summary>
    /// The security systems error messages that can be obtained in methods' responses.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class SecurityException
    {
        /// <remarks/>
        /// <summary>
        /// Description of error cases.
        /// <para>Agency/Agent not found.</para>
        /// No or wrong agency credentials.
        /// <para>Privileges not sufficient to execute requested method.</para>
        /// Wrong payment methods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "message", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Message { get; set; }
    }
}