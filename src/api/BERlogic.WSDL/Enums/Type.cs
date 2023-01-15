namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The type of number base in reports.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum Type
    {
        /// <summary>
        /// the absolute amount in the stock currency
        /// </summary>
        /// <remarks/>
        Flat,

        /// <summary>
        /// in percent of the tariff (fare basis)
        /// </summary>
        /// <remarks/>
        PercentBase,

        /// <summary>
        /// in percent of the total amount
        /// </summary>
        /// <remarks/>
        PercentTotal,
    }
}