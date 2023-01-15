using BERlogic.WSDL.Models.Payment;
using BERlogic.WSDL.Services;

namespace BERlogic.WSDL.Models.Hotels
{
    /// <remarks/>
    /// <summary>
    /// The price to be paid. Used in <see cref="pHotelCancellationRule"/>, <see cref="pHotelRoom"/>, <see cref="pHotelReservation"/> and <see cref="HotelBooking"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class pPrice
    {
        /// <remarks/>
        /// <summary>
        /// Price value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public decimal Amount { get; set; }

        /// <remarks/>
        /// <summary>
        /// The currency in which this price is represented. Supported: EUR, RUB
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "currency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Currency Currency { get; set; }
    }
}