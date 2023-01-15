using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Services
{
    /// <remarks>
    /// Extension for <see cref="Service"/>.
    /// </remarks>
    /// <summary>
    /// Contains information about cost of the railway ticket.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class SPZDBooking : Service
    {
        /// <remarks/>
        /// <summary>
        /// Cost information represents the cost of the railway ticket.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cost", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Cost Cost { get; set; }
    }
}