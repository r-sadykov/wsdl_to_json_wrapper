namespace BERlogic.WSDL.Exceptions
{
    /// <remarks/>
    /// <summary>
    /// Error messages from web service that can be obtained in methods' responses.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class ServiceException
    {
        /// <remarks/>
        /// <summary>
        /// An error code in the system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "errorCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string ErrorCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Description of error cases.
        /// <para>A booking with same traveler information was just recently made. No booking was done.</para>
        /// Cancellation of the ticket is impossible.
        /// <para>Connection to backend servers refused. Try again later.</para>
        /// Could not check flight before booking. No booking was done.
        /// <para>Could not find requested flight, please check flight details.</para>
        /// Create reservation failed.
        /// <para>Not allowed SSR combination.</para>
        /// Not enough seats to complete reservation.
        /// <para>Previous entry in progress, please wait.</para>
        /// Restricted flight in GDS.
        /// <para>The price of the flight has changed.</para>
        /// Traveler information incorrect. Check names and if appropriate date of birth and document information.
        /// <para>Unable to check prices (and the supplied cost is incorrect).</para>
        /// Unknown internal error.
        /// <para>Wrong document.</para>
        /// Аннулирование билета невозможно.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "message", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Message { get; set; }
    }
}