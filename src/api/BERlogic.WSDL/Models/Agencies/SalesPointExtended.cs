using Phaenir.Common.Models;

namespace BERlogic.WSDL.Models.Agencies
{
    /// <remarks/>
    /// <summary>
    /// Extension for <see cref="SalesPoint"/>.
    /// Used in <see cref="AuthenticationResult"/> to list the available sales points.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class SalesPointExtended : SalesPoint, IAgency
    {
        /// <remarks/>
        /// <summary>
        /// If true, then the sales point is allowed to sell Aeroexpress tickets.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyAeroexpressAllowed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool AgencyAeroexpressAllowed { get; set; }

        /// <remarks/>
        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AgencyCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// The email address of the sales point or agency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyEmail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AgencyEmail { get; set; }

        /// <remarks/>
        /// <summary>
        /// The explicit name of the sales point or agency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string AgencyName { get; set; }

        /// <remarks/>
        /// <summary>
        /// The phone number of the sales point or agency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyTelephone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string AgencyTelephone { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of allowed currencies for the sales point or agency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("allowedCurrencies", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string[] AllowedCurrencies { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of allowed payment types for the sales point or agency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("allowedPayments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 6)]
        public string[] AllowedPayments { get; set; }

        /// <remarks/>
        /// <summary>
        /// Default service charge for the sales point or agency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "defaultServiceCharge", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public decimal DefaultServiceCharge { get; set; }

        /// <remarks/>
        /// <summary>
        /// Maximum service charge for the sales point.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "maximumServiceCharge", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public decimal MaximumServiceCharge { get; set; }

        /// <remarks/>
        /// <summary>
        /// Minimum service charge for the sales point.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "minimumServiceCharge", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public decimal MinimumServiceCharge { get; set; }
    }
}