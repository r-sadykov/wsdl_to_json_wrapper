using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Extension for <see cref="BaseResource"/>.
    /// Defines the begin and end locations of the flight segments and technical stops.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Location : BaseResource
    {
        /// <remarks/>
        /// <summary>
        /// The ID (usually IATA code) of the location.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "countryId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string CountryId { get; set; }

        /// <remarks/>
        /// <summary>
        /// If the location is an airport, parentLocationId shows the ID of the city, the airport is located in.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "parentLocationId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string ParentLocationId { get; set; }

        /// <remarks/>
        /// <summary>
        /// The code of railway.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "railwayCodeId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string RailwayCodeId { get; set; }

        /// <remarks/>
        /// <summary>
        /// The type of the location.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public LocationType Type { get; set; }
    }
}