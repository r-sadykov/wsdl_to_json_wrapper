using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <remarks/>
    /// <summary>
    /// Used in <see cref="GetBookingInfosFromReportDB"/>, <see cref="GetBookings"/> and <see cref="GetReport"/> to set parameters (filters) for the bookings search.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class BookingSearchParameter
    {
        /// <remarks/>
        /// <summary>
        /// The list of booking statuses you want to search for.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("bookingStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public System.Nullable<BookingStatus>[] BookingStatus { get; set; }

        /// <summary>
        /// The starting date of search in the date range.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dateFrom", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public System.DateTime DateFrom { get; set; }

        /// <summary>
        /// The closing date of the date range.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dateTo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public System.DateTime DateTo { get; set; }

        /// <summary>
        /// Limit the booking search to particular GDS. May occur one or more times.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gds", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string[] GDS { get; set; }

        /// <summary>
        /// Limit the booking search to particular sales points. May occur one or more times.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includeSalesPoints", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public string[] IncludeSalesPoints { get; set; }

        /// <summary>
        /// Determine the database fields in which the search text will be searched.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("searchFields", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public System.Nullable<SearchFields>[] SearchFields { get; set; }

        /// <summary>
        /// Search text to search for.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "searchText", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string SearchText { get; set; }
    }
}