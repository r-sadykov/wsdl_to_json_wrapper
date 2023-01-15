namespace BERlogic.WSDL.Enums
{
    /// <remarks/>
    /// <summary>
    /// The person's identification document type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public enum IdCardType
    {
        /// <summary>
        /// National identification document for all citizens except Russian; digits/letters
        /// </summary>
        /// <remarks/>
        CIVIL_PASSPORT,

        /// <summary>
        /// Russian national identification document for traveling for Russian citizens; only digits from 0-9, size = 9 characters
        /// </summary>
        /// <remarks/>
        FOREIGN_PASSPORT,

        /// <summary>
        /// Russian national identification document for traveling for Russian diplomats and embassy employees
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        DIPLOMATIC_PASSPORT,

        /// <summary>
        /// Russian birth certificate, that could be used instead of Civil or Foreign Passport for kinders before 14 Years
        /// </summary>
        /// <remarks>
        /// only for Russian citizens; digits/letters.
        /// </remarks>
        BIRTH_NOTIFICATION,

        /// <summary>
        /// Special certificates for special employess in Russia
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        CERTIFICATE_OF_RELEASE,

        /// <summary>
        /// The identification document of sailors
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        SEAMANS_ID,

        /// <summary>
        /// The identification document for militaries
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        MILITARY_ID,

        /// <summary>
        /// Temporary permission of residence for foreign civils that live in Russia
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        RESIDENCE_PERMIT,

        /// <summary>
        /// All other documents that not described in current enumeration.
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        OTHER,

        /// <summary>
        /// Temporary permission of residence for russian civils that live outside Russia
        /// </summary>
        /// <remarks>
        /// </remarks>
        ALIEN_RESIDENT_CARD,

        /// <summary>
        /// Permanent permission of residence for foreign civils that live in Russia
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        PERMANENT_RESIDENT_CARD,

        /// <summary>
        /// Russian national civil identification document
        /// </summary>
        /// <remarks>
        /// only for Russian citizens; only digits from 0-9, size = 10 characters
        /// </remarks>
        PASSPORT,

        /// <summary>
        /// Travel document in which personal data indicated.
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        TRAVEL_DOCUMENT,

        /// <summary>
        /// Official confirmation for person that could be used as ID
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        FACILITATION_DOCUMENT,

        /// <summary>
        /// The certificate that given to russian people that live outside of Russia, has citizenship of other country but decided to return back to Russia under goverment programm.
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        NATURALIZATION_CERTIFICATE,

        /// <summary>
        /// Special ID card for airport, airline and other employes that allow to cross customs and borders
        /// </summary>
        /// <remarks>
        /// used for special cases in Russian GDSs
        /// </remarks>
        BORDER_CROSSING_CARD,
    }
}