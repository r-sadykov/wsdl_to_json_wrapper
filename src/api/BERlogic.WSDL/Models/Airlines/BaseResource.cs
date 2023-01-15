using Phaenir.Common.Models;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Abstract type. Extends through types <see cref="Vendor"/> and <see cref="Location"/>.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Vendor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public abstract partial class BaseResource : IAirlineVendor
    {
        /// <remarks/>
        /// <summary>
        /// A readable representation of the airline or an airport in the language requested.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "displayCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string DisplayCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// The IATA code of airline or an airport.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Id { get; set; }

        /// <remarks>
        /// Currently duplicates the value of the parameter id.
        /// </remarks>
        /// <summary>
        /// Full name of airline or an airport.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Name { get; set; }
    }
}