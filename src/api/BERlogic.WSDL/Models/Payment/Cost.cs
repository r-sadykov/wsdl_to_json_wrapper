using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Services;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// Cost information presents:
    /// <para>• in <see cref="Flight"/> - representing the cost of the single flight;</para>
    /// • in booking information - representing the cost of the whole booking;
    /// <para>• in <see cref="AeroexpressTrain"/> - representing the cost of the Aeroexpress ticket;</para>
    /// •in <see cref="SPZDBooking"/> - representing the cost of the railway ticket.
    /// <para>How to calculate the total cost</para>
    /// The fee at the cost level is a Partner Fee per booking, a different one (BERlogic Fee) is per passenger.
    /// <para>Pattern:</para>
    /// <para>((adult_tariff + adult_taxes+adult_fee) * adult_number + (child_tariff + child_taxes + child_fee) * child_number + (infant_tariff + infant_taxes+infant_fee) * infant_number) + fee + paymentFee + SSR</para>
    /// • adult_fee, child_fee, infant_fee - BERlogic Fee;
    /// <para>• fee - Partner Fee per booking</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Cost
    {
        /// <remarks/>
        /// <summary>
        /// The currency in which this flight/booking/ticket is offered and prices are represented. Supported: EUR, RUB.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "currency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Currency { get; set; }

        /// <remarks/>
        /// <summary>
        /// Cost elements for specific types of passengers.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("elements", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public CostElement[] Elements { get; set; }

        /// <remarks/>
        /// <summary>
        /// The partner (agency or agent) service charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fee", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public decimal Fee { get; set; }

        /// <remarks/>
        /// <summary>
        /// The cost of the special service requests.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "SSRs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public decimal SSRs { get; set; }

        /// <remarks/>
        /// <summary>
        /// Surcharges.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("surcharges", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 4)]
        public Surcharge[] Surcharges { get; set; }
    }
}