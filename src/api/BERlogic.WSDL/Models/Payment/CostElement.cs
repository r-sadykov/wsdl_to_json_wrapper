using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Services;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// Elements of cost distribution in agency price for travel ticket.
    /// Cost elements for specific types of passengers.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class CostElement
    {
        /// <remarks/>
        /// <summary>
        /// The category of the passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "category", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public WSDL.Enums.PassengerCategory Category { get; set; }

        /// <remarks/>
        /// <summary>
        /// A token that contains internal binary data that must be preserved for later usage in the booking process.
        /// <para>Within each flight object there is a so-called context which is important to be inserted in the following requests if referring to that flight. It is different for every flight and can not be switched between two differing flights. Since it is unique for a single flight, it can be cached along with the flight.</para>
        /// In the same way the context is used for <see cref="AirTicket"/>, <see cref="CostElement"/>, <see cref="FlightSegment"/>, <see cref="AeroexpressTrain"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "context", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 1)]
        public byte[] Context { get; set; }

        /// <remarks/>
        /// <summary>
        /// An additional fee (BERlogic Fee) per passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fee", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public decimal Fee { get; set; }

        /// <remarks/>
        /// <summary>
        /// Can be configured for a particular agency. The value of these elements do not participate in total booking cost calculation and given just in informative purposes.
        /// <para>feeB - own fix fee Berlogic</para>
        /// feeP - agency fix fee
        /// <para>fee = feeB + feeP</para>
        /// See also How to calculate the total cost
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "feeB", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public decimal FeeB { get; set; }

        /// <remarks/>
        /// <summary>
        /// Can be configured for a particular agency. The value of these elements do not participate in total booking cost calculation and given just in informative purposes.
        /// <para>feeB - own fix fee Berlogic</para>
        /// feeP - agency fix fee
        /// <para>fee = feeB + feeP</para>
        /// See also How to calculate the total cost
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "feeP", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public decimal FeeP { get; set; }

        /// <remarks/>
        /// <summary>
        /// The tariff price of the flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tariff", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public decimal Tariff { get; set; }

        /// <remarks/>
        /// <summary>
        /// Additional taxes applied to the flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "taxes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public decimal Taxes { get; set; }
    }
}