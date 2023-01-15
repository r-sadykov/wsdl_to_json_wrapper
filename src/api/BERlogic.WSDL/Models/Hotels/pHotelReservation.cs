using BERlogic.WSDL.Services;

namespace BERlogic.WSDL.Models.Hotels
{
    /// <remarks/>
    /// <summary>
    /// Information about hotel reservation that represented in <see cref="HotelBooking"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class pHotelReservation
    {
        /// <remarks/>
        /// <summary>
        /// Commission amount for agents.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "commissionAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public pPrice CommissionAmount { get; set; }

        /// <remarks/>
        /// <summary>
        /// Commission percent for agents.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "commissionPercent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public decimal CommissionPercent { get; set; }

        /// <remarks/>
        /// <summary>
        /// Default check-in time.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "defaultCheckinTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string DefaultCheckinTime { get; set; }

        /// <remarks/>
        /// <summary>
        /// Default check-out time.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "defaultCheckoutTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string DefaultCheckoutTime { get; set; }

        /// <remarks/>
        /// <summary>
        /// Destination id.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "destinationId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int DestinationId { get; set; }

        /// <remarks/>
        /// <summary>
        /// Fax number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fax", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string Fax { get; set; }

        /// <remarks/>
        /// <summary>
        /// Hotel comments about services and rooms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("hotelComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string[] HotelComments { get; set; }

        /// <remarks/>
        /// <summary>
        /// Hotel id.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "hotelId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public int HotelId { get; set; }

        /// <remarks/>
        /// <summary>
        /// Hotel name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "hotelName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string HotelName { get; set; }

        /// <remarks/>
        /// <summary>
        /// Partner invoice number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "partnerInvoiceNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string PartnerInvoiceNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Partner reservation number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "partnerReservationNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string PartnerReservationNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Phone number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string Phone { get; set; }

        /// <remarks/>
        /// <summary>
        /// Reservation date.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reservationDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public System.DateTime ReservationDate { get; set; }

        /// <remarks/>
        /// <summary>
        /// Reservation id.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "reservationId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string ReservationId { get; set; }

        /// <remarks/>
        /// <summary>
        /// List of rooms in hotel.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("rooms", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public pHotelRoom[] Rooms { get; set; }

        /// <summary>
        /// Star rating of hotel.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "starRating", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public int StarRating { get; set; }

        /// <summary>
        /// TCH reservation id.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tchReservationId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string TchReservationId { get; set; }

        /// <summary>
        /// Total price for whole reservation with all charges and fees.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalPrice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public pPrice TotalPrice { get; set; }
    }
}