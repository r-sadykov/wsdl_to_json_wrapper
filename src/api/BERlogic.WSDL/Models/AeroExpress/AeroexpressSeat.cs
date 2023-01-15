using BERlogic.WSDL.Models.Airlines;

namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <remarks/>
    /// <summary>
    /// The AeroExpress seat.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class AeroexpressSeat
    {
        /// <remarks/>
        /// <summary>
        /// The passenger of AeroExpress service.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "passenger", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AeroexpressPassenger Passenger { get; set; }

        /// <remarks/>
        /// <summary>
        /// AeroExpress ticket number.
        /// Is returned for passenger in <see cref="FinishBookingResponse"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "string", ElementName = "ticketNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string TicketNumber { get; set; }
    }
}