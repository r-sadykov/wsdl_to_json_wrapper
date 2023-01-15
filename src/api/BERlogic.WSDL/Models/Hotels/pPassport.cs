using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Hotels
{
    /// <remarks/>
    /// <summary>
    /// Information about the customer's passport. Used in <see cref="pPerson"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class pPassport
    {
        /// <remarks/>
        /// <summary>
        /// Country.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "country", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Country { get; set; }

        /// <remarks/>
        /// <summary>
        /// Family name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "familyName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string FamilyName { get; set; }

        /// <remarks/>
        /// <summary>
        /// First name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string FirstName { get; set; }

        /// <remarks/>
        /// <summary>
        /// Issue date of document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "issueDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public LocalDate IssueDate { get; set; }

        /// <remarks/>
        /// <summary>
        /// Issue place of document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "issuePlace", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string IssuePlace { get; set; }

        /// <remarks/>
        /// <summary>
        /// Issued by.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "issuedBy", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string IssuedBy { get; set; }

        /// <remarks/>
        /// <summary>
        /// Document number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "number", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string Number { get; set; }

        /// <remarks/>
        /// <summary>
        /// Document type.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public pIdDocument Type { get; set; }

        /// <remarks/>
        /// <summary>
        /// Date valid until is document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "validUntil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public LocalDate ValidUntil { get; set; }
    }
}