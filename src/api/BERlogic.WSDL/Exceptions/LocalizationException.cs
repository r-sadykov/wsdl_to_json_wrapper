using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Exceptions
{
    /// <remarks/>
    /// <summary>
    /// The error messages that can be obtained in methods' responses (namely in methods <see cref="GetBooking"/> and <see cref="UpdateBooking"/>).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class LocalizationException
    {
        /// <remarks/>
        /// <summary>
        /// Description of error cases.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "message", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Message { get; set; }
    }
}