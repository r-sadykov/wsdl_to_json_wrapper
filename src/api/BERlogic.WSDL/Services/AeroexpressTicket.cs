using BERlogic.WSDL.Models.AeroExpress;

namespace BERlogic.WSDL.Services
{
    /// <remarks>
    /// Extension for service.
    /// </remarks>
    /// <summary>
    /// Contains Aeroexpress ticket information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/", TypeName = "aeroexpressTicket")] //DevSkim: ignore DS137138
    public partial class AeroexpressTicket : Service
    {
        /// <remarks/>
        /// <summary>
        /// Gets or sets the aeroexpress seats that was by user booked.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("aeroexpressSeats", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public AeroexpressSeat[] AeroexpressSeats { get; set; }

        /// <remarks/>
        /// <summary>
        /// Reservation id for the AeroExpress booking.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reservationId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string ReservationId { get; set; }

        /// <remarks/>
        /// <summary>
        /// AeroExpress ticket number after issuing.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ticketNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string TicketNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// URL from which user could download the ticket.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ticketUrl", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string TicketUrl { get; set; }

        /// <remarks/>
        /// <summary>
        /// Information about the train that user should use in Station.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "train", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public AeroexpressTrain Train { get; set; }
    }
}