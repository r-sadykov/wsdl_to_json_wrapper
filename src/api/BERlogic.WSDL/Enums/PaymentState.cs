namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The payment state.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum PaymentState
    {
        /// <summary>
        /// Payment not received
        /// </summary>
        /// <remarks/>
        NoPayment,

        /// <summary>
        /// the URL for the payment page has been returned to partner
        /// </summary>
        /// <remarks/>
        Prepared,

        /// <summary>
        ///  the payment page has been opened
        /// </summary>
        /// <remarks/>
        Initialized,

        /// <summary>
        /// money has been blocked, ticketing can be done
        /// </summary>
        /// <remarks/>
        Authorized,

        /// <summary>
        /// payment is settled (this is usually connected to the end of the free-of-charge voiding period)
        /// </summary>
        /// <remarks/>
        Acquired,

        /// <summary>
        /// Payment was cancelled by client
        /// </summary>
        /// <remarks/>
        Canceled,

        /// <summary>
        /// Payment was failed by system
        /// </summary>
        /// <remarks/>
        Failed,

        /// <summary>
        /// Payment was returned back to client
        /// </summary>
        /// <remarks/>
        Refunded,
    }
}