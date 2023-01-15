using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Used to describe special service requests in <see cref="FlightSegment"/> and for passenger.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class SSR
    {
        /// <remarks/>
        /// <summary>
        /// Amount of luggage pieces.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "amountOfPieces", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int AmountOfPieces { get; set; }

        /// <remarks/>
        /// <summary>
        /// We construct our internal SSR ID as follows:
        /// <para>[gdsID]-[route]-[ssrID]</para>
        /// where
        /// <para>[route] = id of beginLocation combined with id of endLocation in <see cref="FlightSegment"/></para>
        /// [ssrID] = SSR code in airline, that offers this SSR.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Id { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the RFIC.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "rfic", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string RFIC { get; set; }

        /// <remarks/>
        /// <summary>
        /// Gets or sets the RFISC.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "rfisc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string RFISC { get; set; }

        /// <remarks/>
        /// <summary>
        /// Fare for Special Service Reservation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tariff", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public decimal Tariff { get; set; }

        /// <remarks/>
        /// <summary>
        /// Taxes for Special Service Reservation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "taxes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public decimal Taxes { get; set; }

        /// <remarks/>
        /// <summary>
        /// Type of Special Service Reservation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public SSRType Type { get; set; }

        /// <remarks/>
        /// <summary>
        /// Luggage weight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "weight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public double Weight { get; set; }

        /// <remarks/>
        /// <summary>
        /// Luggage weight concept type.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "weightType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public SSRWeightType WeightType { get; set; }

        /// <remarks/>
        /// <summary>
        /// Indicates whether the Special Service Reservation is applicable to the whole flight leg (for the flights with stopovers).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "wholeLeg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public bool WholeLeg { get; set; }
    }
}