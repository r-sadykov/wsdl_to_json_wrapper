namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Update passenger request
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "updatePassenger", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class UpdatePassenger
    {
        /// <summary>
        /// Settings, required to change information about passenger
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "settings", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UpdatePassengerSettings Settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePassenger"/> class.
        /// </summary>
        public UpdatePassenger()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePassenger"/> class.
        /// </summary>
        /// <param name="settings">Settings, required to change information about passenger.</param>
        public UpdatePassenger(UpdatePassengerSettings settings)
        {
            this.Settings = settings;
        }
    }
}