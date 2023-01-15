using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <remarks/>
    /// <summary>
    /// Logging message from the BERlogic's system obtained in the booking process.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class BookingLogItem
    {
        /// <remarks/>
        /// <summary>
        /// The date and time of the entry.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public System.DateTime Date { get; set; }

        /// <remarks/>
        /// <summary>
        /// The log message itself.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "message", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Message { get; set; }

        /// <remarks/>
        /// <summary>
        /// The severity level.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "severity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public Severity Severity { get; set; }
    }
}