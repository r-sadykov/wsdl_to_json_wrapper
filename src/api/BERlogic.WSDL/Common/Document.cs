using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Common
{
    /// <remarks/>
    /// <summary>
    /// Used in <see cref="BookingBase"/> to describe documents that can be send to a customer (end-user) during the booking process.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Document
    {
        /// <remarks/>
        /// <summary>
        /// Charset that used in text Encoding.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "charset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Charset { get; set; }

        /// <remarks/>
        /// <summary>
        /// The binary data that issued by system into document as content (encoded in BASE64).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "data", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 1)]
        public byte[] Data { get; set; }

        /// <remarks/>
        /// <summary>
        /// The mimetype of the data, for example "application/pdf".
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mimeType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string MimeType { get; set; }

        /// <remarks/>
        /// <summary>
        /// The "filename" of the document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string Name { get; set; }

        /// <remarks/>
        /// <summary>
        /// The type of documents described in enumeration <see cref="DocumentType"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public DocumentType Type { get; set; }
    }
}