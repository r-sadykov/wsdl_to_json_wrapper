using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Passengers;

namespace BERlogic.WSDL.Services
{
    /// <remarks>
    /// Extension for <see cref="Service"/>.
    /// </remarks>
    /// <summary>
    /// Contains insurance information.Some parameters are returned in <see cref="FinishBookingResponse"/> (see "Return-only" remark).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/", TypeName = "insurance")] //DevSkim: ignore DS137138
    public partial class Insurance : Service
    {
        /// <remarks/>
        /// <summary>
        /// Value of the insurance policy. Return-only.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Amount { get; set; }

        /// <remarks/>
        /// <summary>
        /// Value of insurance compensation. Return-only.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amountInsured", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AmountInsured { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the сreated.
        /// The issue date and time for Insurance. Return-only.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "created", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public System.DateTime Created { get; set; }

        /// <remarks/>
        /// <summary>
        /// Insurance registration date.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "declarationDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public System.DateTime DeclarationDate { get; set; }

        /// <remarks/>
        /// <summary>
        /// Public insurance declaration number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "declarationNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string DeclarationNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Internal code of the insurance policy. Return-only.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string Id { get; set; }

        /// <remarks>
        /// It is allowed to use only lowercase letter.
        /// </remarks>
        /// <summary>
        /// The state of the insurance policy. See <see cref="Status"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "insuranceStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public Status InsuranceStatus { get; set; }

        /// <remarks/>
        /// <summary>
        /// Information about the passenger for whom the insurance is issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "passenger", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public Passenger Passenger { get; set; }

        /// <remarks/>
        /// <summary>
        /// Insurance product code that corresponds between BERlogic's system and Insurance provider.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "productCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string ProductCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Identification number of Insurance provider.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "providerId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string ProviderId { get; set; }

        /// <remarks/>
        /// <summary>
        /// The number of the insurance policy. Return-only.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "publicId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string PublicId { get; set; }

        /// <remarks/>
        /// <summary>
        /// Airline ticket number on which the insurance is valid.
        /// Is returned for passenger in <see cref="FinishBookingResponse"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ticketNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string TicketNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Date and Time of any changes in Insurance.
        /// Return-only.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "updated", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public System.DateTime Updated { get; set; }
    }
}