using BERlogic.WSDL.Models.Hotels;

namespace BERlogic.WSDL.Services
{
    /// <remarks>
    /// Extension for service.
    /// </remarks>
    /// <summary>
    /// Contains information about hotel reservation and total reservation price.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/", TypeName = "hotelBooking")] //DevSkim: ignore DS137138
    public partial class HotelBooking : Service
    {
        /// <remarks/>
        /// <summary>
        /// Information about hotel reservation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "hotelReservation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public pHotelReservation HotelReservation { get; set; }

        /// <remarks/>
        /// <summary>
        /// Total price of the hotel reservation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalPrice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public pPrice TotalPrice { get; set; }
    }
}