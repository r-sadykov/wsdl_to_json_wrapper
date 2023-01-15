namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The status of booking service.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum Status
    {
        /// <summary>
        /// Service was requested, but not issued
        /// </summary>
        /// <remarks/>
        requested,

        /// <summary>
        /// Service was registered
        /// </summary>
        /// <remarks/>
        registered,

        /// <summary>
        /// Service was cancelled, but payment not returned
        /// </summary>
        /// <remarks/>
        reversed,

        /// <summary>
        /// Payment returned
        /// </summary>
        /// <remarks/>
        refunded,
    }
}