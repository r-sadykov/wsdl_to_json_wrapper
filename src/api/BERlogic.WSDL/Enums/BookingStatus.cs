namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The booking status.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum BookingStatus
    {
        ///<summary>
        /// Reservation is done, PNR created.
        /// </summary>
        /// <remarks/>
        CONFIRMED,

        ///<summary>
        /// Reservation is not done, the flight is in the waitlist.
        /// </summary>
        /// <remarks/>
        WAIT_LIST,

        ///<summary>
        /// Reservation is not done.
        /// </summary>
        /// <remarks/>
        UNCONFIRMED,

        ///<summary>
        /// The PNR is cancelled, segments are deleted.
        /// </summary>
        /// <remarks/>
        CANCELLED,

        ///<summary>
        /// The status in GDS is not clear, manual check recommended.
        /// </summary>
        /// <remarks/>
        ERROR,

        ///<summary>
        /// The order is ticketed.
        /// </summary>
        /// <remarks/>
        COMPLETED,

        ///<summary>
        /// No status data available.
        /// </summary>
        /// <remarks/>
        UNDEFINED,

        ///<summary>
        /// All the tickets within the booking are refunded.
        /// </summary>
        /// <remarks/>
        REFUNDED,

        ///<summary>
        /// All the tickets within the booking are voided.
        /// </summary>
        /// <remarks/>
        VOIDED,

        ///<summary>
        ///
        /// </summary>
        /// <remarks/>
        DUPLICATED,
    }
}