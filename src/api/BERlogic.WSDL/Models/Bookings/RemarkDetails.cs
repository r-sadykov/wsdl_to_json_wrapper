using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <remarks/>
    /// <summary>
    /// The remark details.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class RemarkDetails
    {
        /// <remarks/>
        /// <summary>
        /// Category of remarks.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "category", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Category { get; set; }

        /// <remarks>
        /// It is allowed to use only uppercase letter.
        /// </remarks>
        /// <summary>
        /// Define a type of remark as group defined in enumeration <see cref="RemarkGroup"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "group", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public RemarkGroup Group { get; set; }

        /// <remarks/>
        /// <summary>
        /// Person name that defined in booking documents.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "personName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string PersonName { get; set; }

        /// <remarks/>
        /// <summary>
        /// Remark qualifier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "qualifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string Qualifier { get; set; }

        /// <remarks/>
        /// <summary>
        /// Shows the current booking status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string Status { get; set; }

        /// <remarks/>
        /// <summary>
        /// Shows the supplier code that issue travel service.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "supplierCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string SupplierCode { get; set; }
    }
}