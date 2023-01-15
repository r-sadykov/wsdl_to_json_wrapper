using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// The strong type of customer authorization.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class StrongCustomerAuth
    {
        /// <remarks/>
        /// <summary>
        /// Gets or sets the DSID.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dsid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string DSID { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the ECI.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "eci", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string ECI { get; set; }

        /// <remarks/>
        /// <summary>
        /// Possible exceptions during booking process.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "exemptions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Exceptions { get; set; }

        /// <remarks/>
        /// <summary>
        /// The protocol type of authorization.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "protocol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public StrongCustomerAuthProtocol Protocol { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the SLI.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "sli", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string SLI { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the UCAV.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ucav", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string UCAV { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the XID.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "xid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string XID { get; set; }
    }
}