using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Payment;
using BERlogic.WSDL.Services;

using Phaenir.Common.Models;

namespace BERlogic.WSDL.Models.Passengers
{
    /// <remarks/>
    /// <summary>
    /// Contains information about the passenger for <see cref="AirTicket"/> and <see cref="Insurance"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Passenger : IPerson, IPersonBorn
    {
        /// <remarks/>
        /// <summary>
        /// A passengers birthday. Mandatory.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "birthday", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public System.DateTime Birthday { get; set; }

        /// <remarks/>
        /// <summary>
        /// The category of the passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "category", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public BERlogic.WSDL.Enums.PassengerCategory Category { get; set; }

        /// <remarks/>
        /// <summary>
        /// Two-letter ISO code of the country(e.g.RU, US, DE). Mandatory.
        /// <para>If passenger citizenship is not specified it is set to RU if the passenger has one of the following idCardType's:</para>
        /// • PASSPORT
        /// <para>• BIRTH_NOTIFICATION</para>
        /// • FOREIGN_PASSPORT
        /// <para>For all other citizenship please use CIVIL_PASSPORT.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "citizenship", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Citizenship { get; set; }

        /// <remarks/>
        /// <summary>
        /// Commission that passenger should pay.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "commission", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Commission Commission { get; set; }

        /// <remarks/>
        /// <summary>
        /// So called frequent flyer card also known as mile card of airlines or alliances. Input data is card number without any airline prefixes. No validation on BERlogic's site.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "discountCardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string DiscountCardNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Contains the list of identification numbers for ancillary services/SSRs generated in the BERlogic system and sent to partners in <see cref="FinishBookingResponse"/> every time an additional service is booked:
        /// <para>• key = EMD number;</para>
        /// • value = id in special servise reservation - our internal SSR ID.
        /// <para>For the passenger without SSRs we do send nothing.</para>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public PassengerEntry[] EmdSSRs { get; set; }

        /// <remarks/>
        /// <summary>
        /// Fare calculation on chosen service.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fareCalculation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string FareCalculation { get; set; }

        /// <remarks/>
        /// <summary>
        /// First and last (calling- and family-name) of the passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "firstName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string FirstName { get; set; }

        /// <remarks/>
        /// <summary>
        /// The gender of the passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "gender", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public BERlogic.WSDL.Enums.Gender Gender { get; set; }

        /// <remarks/>
        /// <summary>
        /// The expiry date of the document (e.g. passport). Required if passportRequired = true in flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "idCardExpireDate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public System.DateTime IdCardExpireDate { get; set; }

        /// <remarks/>
        /// <summary>
        /// The number of the document. Required if passportRequired = true in flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "idCardNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string IdCardNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// The type of the document. Required if passportRequired = true in flight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "idCardType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public IdCardType IdCardType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Last (family) name of the passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string LastName { get; set; }

        /// <remarks/>
        /// <summary>
        /// An optional middle name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "middleName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string MiddleName { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of special service requests for passenger.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SSRs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 14)]
        public string[] SSRs { get; set; }

        /// <remarks/>
        /// <summary>
        /// Is returned in <see cref="FinishBookingResponse"/>.
        /// <para>It can be a string containing comma separated numbers of passenger’s tickets. The situation with several values is a rare special case when one passenger has several tickets. The example of what it may look like:</para>
        /// &lt;ticketNumber&gt; 0144981550620, 0144981550621 &lt;/ticketNumber&gt;.
        /// <para>In case of conjunction tickets that are coming from Sabre, ticket number will be imported as a single ticket.The example of what it may look like:</para>
        /// &lt;ticketNumber&gt; 0144981550620/21 &lt;/ticketNumber&gt;.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ticketNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string TicketNumber { get; set; }

        /// <remarks/>
        /// <summary>
        /// Is returned in <see cref="FinishBookingResponse"/>.
        /// <para>It can be a string containing comma separated statuses of passenger’s tickets.The situation with several values is a rare special case when one passenger has several tickets. The example of what it may look like:</para>
        /// &lt;ticketStatus&gt; Exchanged, Issued &lt;/ticketStatus&gt;.
        /// <para>In case of conjunction tickets that are coming from Sabre, ticket number will be imported as a single ticket:</para>
        /// &lt;ticketNumber&gt; 0144981550620/21 &lt;/ticketNumber&gt;
        /// <para>&lt;ticketStatus&gt; Issued &lt;/ticketStatus&gt;</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ticketStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string TicketStatus { get; set; }
    }
}