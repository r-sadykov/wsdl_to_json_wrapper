using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Passengers
{
    /// <remarks/>
    /// <summary>
    /// Information about a customer (end-user) that represented in <see cref="BookingBase"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Contact
    {
        /// <remarks/>
        /// <summary>
        /// birthday
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "birthday", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public System.DateTime Birthday { get; set; }

        /// <remarks/>
        /// <summary>
        /// The city name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "city", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string City { get; set; }

        /// <remarks/>
        /// <summary>
        /// The company name of the customer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "company", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Company { get; set; }

        /// <remarks/>
        /// <summary>
        /// Two-letter country code of the customers residence.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "country", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string Country { get; set; }

        /// <remarks/>
        /// <summary>
        /// The email address of the customer, where the invoice or other documents will be sent.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "email", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string Email { get; set; }

        /// <remarks/>
        /// <summary>
        /// The fax number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fax", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string Fax { get; set; }

        /// <remarks/>
        /// <summary>
        /// The first name of the end-user. Only one of them is mandatory.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string FirstName { get; set; }

        /// <remarks/>
        /// <summary>
        /// Full name of customer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fullName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string FullName { get; set; }

        /// <remarks/>
        /// <summary>
        /// The gender of the end-user.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "gender", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public Gender Gender { get; set; }

        /// <remarks/>
        /// <summary>
        /// The house number in the postal address.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "houseNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string HouseNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// The IP-address from which customer made his order.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ipAddress", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string IPAddress { get; set; }

        /// <remarks/>
        /// <summary>
        /// The last name of the end-user. Only one of them is mandatory.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string LastName { get; set; }

        /// <remarks/>
        /// <summary>
        /// An optional middle name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "middleName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string MiddleName { get; set; }

        /// <remarks/>
        /// <summary>
        /// Some telephone number of the customer. Only one of them is mandatory.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mobile", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string Mobile { get; set; }

        /// <remarks/>
        /// <summary>
        /// Notes with comments from system about booking process.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "notes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string Notes { get; set; }

        /// <remarks/>
        /// <summary>
        /// Private (home) telephone number of the customer. Only one of them is mandatory.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneHome", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string PhoneHome { get; set; }

        /// <summary>
        /// Working telephone number of the customer. Only one of them is mandatory.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneWork", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string PhoneWork { get; set; }

        /// <summary>
        /// The postal address, usually the street with number or PO box.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "postAddress", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public string PostAddress { get; set; }

        /// <summary>
        /// The region, or federal state of the customer.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "region", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public string Region { get; set; }

        /// <summary>
        /// The zip or postal code of the city.
        /// </summary>
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "zipCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public string ZipCode { get; set; }
    }
}