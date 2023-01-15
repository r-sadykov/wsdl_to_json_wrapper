using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Bookings;
using BERlogic.WSDL.Models.Passengers;
using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Services
{
    /// <remarks>
    /// Extension for service.
    /// </remarks>
    /// <summary>
    /// Contains air ticket information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/", TypeName = "airTicket")] //DevSkim: ignore DS137138
    public partial class AirTicket : Service
    {
        /// <remarks/>
        /// <summary>
        /// A token that contains internal binary data that must be preserved for later usage in the booking process.
        /// <para>Within each flight object there is a so-called context which is important to be inserted in the following requests if referring to that flight.It is different for every flight and can not be switched between two differing flights.Since it is unique for a single flight, it can be cached along with the flight.</para>
        /// <para>In the same way the context is used for <see cref="AirTicket"/>, <see cref="CostElement"/>, <see cref="FlightSegment"/>, <see cref="AeroexpressTrain"/>.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "context", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 0)]
        public byte[] Context { get; set; }

        /// <remarks/>
        /// <summary>
        /// Contains flight information.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "flight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Flight Flight { get; set; }

        /// <remarks/>
        /// <summary>
        /// If true, the booking is imported from the GDS.
        /// If false, the booking had been done through the BERlogic system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "imported", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool Imported { get; set; }

        /// <remarks/>
        /// <summary>
        /// Contains passenger information. May occur one or more times.
        /// <para>In case of splitting you can see in <see cref="ImportBooking"/> response and in <see cref="UpdateBooking"/> response either all passengers from initial PNR(parameter recordLocators) or only those passengers who actually remained in this PNR after splitting.The service is configurable per partner(tenant, agency) in BERlogic system using a special key value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("passengers", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public Passenger[] Passengers { get; set; }

        /// <remarks/>
        /// <summary>
        /// The "main" booking ID in the database of the GDS (e.g. PNR). It is a combination of six characters - letters and numbers.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "recordLocator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string RecordLocator { get; set; }

        /// <remarks/>
        /// <summary>
        /// New PNR created by splitting, or initial PNR for which split was made. In case several PNRs were created they will be presented in a collection of strings.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("splitLocators", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 5)]
        public string[] SplitLocators { get; set; }

        /// <remarks/>
        /// <summary>
        /// On which stock the ticket is issued. It is allowed to use only uppercase letter.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "stock", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string Stock { get; set; }

        /// <remarks/>
        /// <summary>
        /// Determines the time(UTC) by which the flight can be ticketed.
        /// <para>If a reservation took place, this shows until when the reservation is valid.If there was no reservation due to restrictions of the airline, this will either show the time of now or some moment of the past.Time is by UTC and this time does not correspond to the time zone configured for the sales point.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "timeLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public System.DateTime TimeLimit { get; set; }
    }
}