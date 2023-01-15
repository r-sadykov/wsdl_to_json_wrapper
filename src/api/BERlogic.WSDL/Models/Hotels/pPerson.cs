using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Hotels
{
    /// <remarks/>
    /// <summary>
    /// Personal data of a person that represented in <see cref="pHotelRoom"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class pPerson
    {
        /// <remarks/>
        /// <summary>
        /// Additional names of passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "additionalNames", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string AdditionalNames { get; set; }

        /// <summary>
        /// Additional names in localized form.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "additionalNamesLocalized", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AdditionalNamesLocalized { get; set; }

        /// <summary>
        /// Age of passenger.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "age", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public int Age { get; set; }

        /// <summary>
        /// Birth date of passenger.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "birthDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public LocalDate BirthDate { get; set; }

        /// <summary>
        /// Citizen country code.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "citizenCountryCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string CitizenCountryCode { get; set; }

        /// <summary>
        /// Family name.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "familyName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string FamilyName { get; set; }

        /// <summary>
        /// Family name in localized form.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "familyNameLocalized", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string FamilyNameLocalized { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string FirstName { get; set; }

        /// <summary>
        /// First name in localized form.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstNameLocalized", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string FirstNameLocalized { get; set; }

        /// <remarks/>
        /// <summary>
        /// Passengers' passports.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("passports", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public pPassport[] Passports { get; set; }

        /// <remarks/>
        /// <summary>
        /// Personal documents.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public pPersonEntry[] PersonalDocuments { get; set; }

        /// <summary>
        /// Passenger gender.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "sex", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public pSex Sex { get; set; }

        /// <summary>
        /// Title of passengers.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "title", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string Title { get; set; }

        /// <summary>
        /// Title in localized form.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "titleLocalized", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string TitleLocalized { get; set; }
    }
}