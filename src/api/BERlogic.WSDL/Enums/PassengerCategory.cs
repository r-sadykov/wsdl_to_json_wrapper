namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The passenger category.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum PassengerCategory
    {
        /// <summary>
        /// From 24 (18 if do not have Student ID) to 65 Year
        /// </summary>
        /// <remarks/>
        ADULT,

        /// <summary>
        /// from 0 to 3 Year
        /// </summary>
        /// <remarks/>
        INFANT,

        /// <summary>
        /// from 3 to 12 Year
        /// </summary>
        /// <remarks/>
        CHILD,

        /// <summary>
        /// At 65 Year
        /// </summary>
        /// <remarks/>
        SENIOR,

        /// <summary>
        /// From 18 to 24 Years with Student card
        /// </summary>
        /// <remarks/>
        STUDENT,

        /// <summary>
        /// From 12 to 18 Years
        /// </summary>
        /// <remarks/>
        YOUTH,
    }
}