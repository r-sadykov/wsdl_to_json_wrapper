using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Payment
{
    /// <remarks/>
    /// <summary>
    /// Payment information. Used in <see cref="BookingBase"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Payment
    {
        /// <remarks/>
        /// <summary>
        /// Credit card details.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "cc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public CreditCard CreditCard { get; set; }

        /// <remarks/>
        /// <summary>
        /// Payment code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "code", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Code { get; set; }

        /// <remarks/>
        /// <summary>
        /// The currency for the payment. Supported: EUR, RUB.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "currency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Currency { get; set; }

        /// <remarks/>
        /// <summary>
        /// The date, the transaction finished.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public System.DateTime Date { get; set; }

        /// <remarks>
        /// SIRENA_CC_ONLINE
        /// </remarks>
        /// <summary>
        /// The payment gate will redirect to this URL in case of payment clearing failure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "failureUrl", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "anyURI", Order = 4)]
        public string FailureUrl { get; set; }

        /// <remarks>
        /// Deprecated
        /// </remarks>
        /// <summary>
        /// Indicates that EMD90 was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "issueEmd90", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public bool IssueEMD90 { get; set; }

        /// <summary>
        /// Direct debit payment method details.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastschrift", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public Lastschrift Lastschrift { get; set; }

        /// <summary>
        /// Return string with transaction status and transaction number.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "notes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string Notes { get; set; }

        /// <summary>
        /// Payment number.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "number", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string Number { get; set; }

        /// <remarks/>
        /// <summary>
        /// Fee taken for this particular type of payment. Used only on the markets where allowed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "paymentFee", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public decimal PaymentFee { get; set; }

        /// <summary>
        /// Payment provider's page URL.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "paymentPage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "anyURI", Order = 10)]
        public string PaymentPage { get; set; }

        /// <summary>
        /// The total price to be paid, including all taxes and fees. Must be provided so that BERlogic can check, it will only charge the amount, the end-user and the partner/agency expects to be charged. Is based on booking -> costElement.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "price", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public decimal Price { get; set; }

        /// <summary>
        /// The invoice number or any other information that will be sent to GDS. Note: currently the invoice remark could be send only to the GDS SIRENA_DIRECT.
        /// </summary>
        /// <remarks>
        /// Only for payment type "INVOICE".
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "remark", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string Remark { get; set; }

        /// <summary>
        /// The payment status.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "state", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public PaymentState State { get; set; }

        /// <summary>
        /// The payment gate will redirect to this URL in case of payment clearing success.
        /// </summary>
        /// <remarks>
        /// SIRENA_CC_ONLINE
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "successUrl", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "anyURI", Order = 14)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Determines the time (UTC) by which the flight can be ticketed.
        /// <para>If a reservation took place, this shows until when the reservation is valid. If there was no reservation due to restrictions of the airline, this will either show the time of now or some moment of the past. Time is by UTC and this time does not correspond to the time zone configured for the sales point.</para>
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public System.DateTime TimeLimit { get; set; }

        /// <summary>
        /// Gets or sets the timeout in minutes.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeout", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public int Timeout { get; set; }

        /// <summary>
        /// The payment type.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public PaymentType Type { get; set; }
    }
}