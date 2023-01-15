using Phaenir.Common.Models;

namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <remarks/>
    /// <summary>
    /// Set data of passenger that uses russian AeroExpress service.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class AeroexpressPassenger : IPerson, IPersonDocument
    {
        /// <remarks/>
        /// <summary>
        /// First name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "string", ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string FirstName { get; set; }

        /// <remarks/>
        /// <summary>
        /// Person's identification document number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "string", ElementName = "idDocumentNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string IdDocumentNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Person's identification document type.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "string", ElementName = "idDocumentType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string IdDocumentType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Last name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "string", ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string LastName { get; set; }

        /// <remarks/>
        /// <summary>
        /// Middle name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "string", ElementName = "middleName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string MiddleName { get; set; }
    }
}