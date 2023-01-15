namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The p id document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum pIdDocument
    {
        /// <summary>
        /// National identification document
        /// </summary>
        /// <remarks/>
        CIVIL_PASSPORT,

        /// <summary>
        /// Russian national civil identification document
        /// </summary>
        /// <remarks/>
        PASSPORT,

        /// <summary>
        /// Russian national identification document for traveling for Russian diplomats and embassy employees
        /// </summary>
        /// <remarks/>
        FOREIGN_PASSPORT,

        /// <summary>
        /// Russian birth certificate, that could be used instead of Civil or Foreign Passport for kinders before 14 Years
        /// </summary>
        /// <remarks/>
        BIRTH_NOTIFICATION,

        /// <summary>
        /// The identification document for militaries
        /// </summary>
        /// <remarks/>
        MILITARY_ID,

        /// <summary>
        /// ID document for invalids
        /// </summary>
        /// <remarks/>
        INVALID,
    }
}