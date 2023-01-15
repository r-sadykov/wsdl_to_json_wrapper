namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The search fields in request to get information about booking.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum SearchFields
    {
        /// <summary>
        /// The name of passenger that should use ticket on ordered transport
        /// </summary>
        /// <remarks/>
        PASSENGER_NAME,

        /// <summary>
        /// The name of person who ordered the transport service. Could not be passenger.
        /// </summary>
        /// <remarks/>
        CUSTOMER_NAME,

        /// <summary>
        /// Returned from GDS or Airline unique number of passenger
        /// </summary>
        /// <remarks/>
        PNR,

        /// <summary>
        /// Any other text that could be used as search parameter
        /// </summary>
        /// <remarks/>
        FULL_TEXT,
    }
}