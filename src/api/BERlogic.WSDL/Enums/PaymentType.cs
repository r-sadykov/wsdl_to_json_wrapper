namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The payment type that could customer use in ticket payment.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum PaymentType
    {
        /// <summary>
        /// used for cash payments at the Partner's office, configured for Partner with a Deposit;
        /// </summary>
        /// <remarks/>
        CASH_OFFICE,

        /// <summary>
        /// used for credit card payments at the Partner's office;
        /// </summary>
        /// <remarks/>
        CC_OFFICE,

        /// <summary>
        /// used for credit card payments in EUR via Gateline;
        /// </summary>
        /// <remarks/>
        CC_ONLINE,

        /// <summary>
        /// used for payment by invoice in EUR and RUB;
        /// </summary>
        /// <remarks/>
        INVOICE,

        /// <summary>
        /// used for credit card payments in RUB via Gateline, eGo (Sirena payment gate) and Rietumu PSP
        /// => only for payments by credit card with the data input on the payment gateway site
        /// </summary>
        /// <remarks/>
        SIRENA_CC_ONLINE,

        /// <summary>
        /// used for payments in EUR, Direct Debit
        /// </summary>
        /// <remarks/>
        LASTSCHRIFT,
    }
}