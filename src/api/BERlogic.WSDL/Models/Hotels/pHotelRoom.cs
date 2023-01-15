namespace BERlogic.WSDL.Models.Hotels
{
    /// <remarks/>
    /// <summary>
    /// Information about a hotel room. Used in <see cref="pHotelReservation"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class pHotelRoom
    {
        /// <remarks/>
        /// <summary>
        /// Bed type in the room.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "bedType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string BedType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Cancellation rules for hotel reservation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("cancellationRules", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public pHotelCancellationRule[] CancellationRules { get; set; }

        /// <summary>
        /// Date and time for check in.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "checkIn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public System.DateTime CheckIn { get; set; }

        /// <summary>
        /// Date and time for check out.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "checkOut", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public System.DateTime CheckOut { get; set; }

        /// <remarks/>
        /// <summary>
        /// Guests list.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("guests", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public pPerson[] Guests { get; set; }

        /// <summary>
        /// Hotel reservation number.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "hotelReservationNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string HotelReservationNumber { get; set; }

        /// <summary>
        /// Meal type.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mealType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string MealType { get; set; }

        /// <summary>
        /// Indicates whether the reservation is non refundable or not.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "nonRefundable", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public bool NonRefundable { get; set; }

        /// <summary>
        /// Indicates whether reservation on request or not.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "onRequest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public bool OnRequest { get; set; }

        /// <summary>
        /// Indicates whether reservation post pay or not.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "postPay", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public bool PostPay { get; set; }

        /// <summary>
        /// Room description.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "roomDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string RoomDescription { get; set; }

        /// <summary>
        /// Room name.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "roomName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string RoomName { get; set; }

        /// <summary>
        /// Room type.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "roomType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string RoomType { get; set; }

        /// <summary>
        /// Taxes in reservation.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "taxes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public pPrice Taxes { get; set; }

        /// <summary>
        /// TCH refund amount if used Sirena.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tchRefundAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public decimal TchRefundAmount { get; set; }

        /// <summary>
        /// TCH refund EMD.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tchRefundEmd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string TchRefundEmd { get; set; }

        /// <summary>
        /// TCH ticket amount for reservation.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tchTicketAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public pPrice TchTicketAmount { get; set; }

        /// <summary>
        /// TCH ticket EMD number.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tchTicketEmdNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public string TchTicketEmdNumber { get; set; }

        /// <summary>
        /// Total price for hotel reservation with all charges.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "totalPrice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public pPrice TotalPrice { get; set; }

        /// <summary>
        /// VAT value.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vat", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public pPrice VAT { get; set; }

        /// <summary>
        /// Vendor name.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public string Vendor { get; set; }

        /// <summary>
        /// Vendor reservation id.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "vendorReservationId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public string VendorReservationId { get; set; }
    }
}