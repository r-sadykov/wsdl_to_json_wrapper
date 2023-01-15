using Phaenir.Common.Models;

namespace BERlogic.WSDL.Models.AeroExpress
{
    /// <remarks/>
    /// <summary>
    /// The information about booked AeroExpress seat.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class AeroexpressSeatInfo : ILandTransportSchedule
    {
        /// <remarks/>
        /// <summary>
        /// Arrival time for train.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "arrivalTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string ArrivalTime { get; set; }

        /// <remarks/>
        /// <summary>
        /// The date of AeroExpress service that user want to use.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Date { get; set; }

        /// <remarks/>
        /// <summary>
        /// Departure time of train.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "departureTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string DepartureTime { get; set; }

        /// <remarks/>
        /// <summary>
        /// Schedule id.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "schedId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public int SchedId { get; set; }

        /// <remarks/>
        /// <summary>
        /// Seat number in the AeroExpress train that client chose.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "seatNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int SeatNumber { get; set; }
    }
}