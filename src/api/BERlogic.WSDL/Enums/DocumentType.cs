namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The document type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum DocumentType
    {
        /// <summary>
        /// Confirmation that ticket was reserved but not paid
        /// </summary>
        /// <remarks/>
        CONFIRMATION,

        /// <summary>
        /// Confirmation that ticket was issued
        /// </summary>
        /// <remarks/>
        TICKET,

        /// <summary>
        /// Financial payment confirmation
        /// </summary>
        /// <remarks/>
        RECEIPT,

        /// <summary>
        /// Information about booking process
        /// </summary>
        /// <remarks/>
        REPORT,

        /// <summary>
        /// Issued by GDS or Airline document to confirm paid ticket at Airport
        /// </summary>
        /// <remarks/>
        TRAVELDOCUMENT,

        /// <summary>
        /// Any other documents that not specified in this enumeration
        /// </summary>
        /// <remarks/>
        OTHER,
    }
}