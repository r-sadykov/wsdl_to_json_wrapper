using BERlogic.WSDL.Common;
using BERlogic.WSDL.Enums;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// Several parameters that adapt the search request to the user's wishes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class FlightSearchSettings
    {
        /// <summary>
        /// The basic contructor to initialize object <see cref="FlightSearchSettings"/> with data by default.
        /// </summary>
        public FlightSearchSettings() { }

        /// <summary>
        /// The extented contructor to initialize object <see cref="FlightSearchSettings"/> with data passed through parameter.
        /// </summary>
        /// <param name="agent">Information about agent that issues service</param>
        public FlightSearchSettings(BerlogicAgent agent)
        {
            AgencyCode = agent.AgencyCode;
            AgentCode = agent.AgentCode;
            AgentPassword = agent.AgentPassword;
            Lang = agent.Lang;
            PreferredCurrency = agent.PreferredCurrency;
            SalesPoint = agent.SalesPoint.Code;
        }

        /// <remarks/>
        /// <summary>
        /// Available seats on the flight for different category of passengers.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(ElementName = "seats", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public FlightSearchSettingsEntry[] Seats { get; set; }

        /// <remarks/>
        /// <summary>
        /// Represents internal code of agency from which agent make operations
        /// Code of the agency that was created in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agencyCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AgencyCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Represents internal code of agent in BERlogic System.
        /// Also could be replaced by email or login which used to get access
        /// into Multioffice
        /// Agent's login for accessing the system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AgentCode { get; set; }

        /// <remarks/>
        /// <summary>
        /// Given by BERlogic the password for Agent or Multioffice user
        /// The assigned password for the agent.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agentPassword", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string AgentPassword { get; set; }

        /// <remarks/>
        /// <summary>
        /// A digit, representing the number of days around the departure date that should be searched.
        /// <para>For example, if route/date is 2011-01-10 and dateTolerance is 2, all flights from 2011-01-08 to 2011-01-12 (both inclusive) are searched for the route. A dateTolerance of 0 means only the specified date is searched.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "dateTolerance", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int DateTolerance { get; set; }

        /// <remarks/>
        /// <summary>
        /// If true, only flights with e-Ticket will be returned.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "eticketsOnly", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public bool ETicketsOnly { get; set; }

        /// <remarks/>
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string Lang { get; set; }

        /// <remarks/>
        /// <summary>
        /// To request the system to combine flights from different airlines.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mixedVendors", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public bool MixedVendors { get; set; }

        /// <remarks/>
        /// <summary>
        /// The currency in which this flight is offered and prices are represented. Supported: EUR, RUB.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "preferredCurrency", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string PreferredCurrency { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines the list of preferred airlines.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("preferredVendors", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public string[] PreferredVendors { get; set; }

        /// <remarks/>
        /// <summary>
        /// Defines one leg (or direction) of a flight. May occur one or more times.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("route", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 10)]
        public RouteSegment[] Route { get; set; }

        /// <remarks/>
        /// <summary>
        /// Salespoint information from wich all services orders made.
        /// One of the authentication parameters. Code of the salespoint that belongs to the agency created in the BERlogic system for partner's connection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "salesPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string SalesPoint { get; set; }

        /// <remarks/>
        /// <summary>
        /// Service class on the board of transport.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "serviceClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public ServiceClass ServiceClass { get; set; }

        /// <remarks/>
        /// <summary>
        /// If true, only direct flights will be returned.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "skipConnected", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public bool SkipConnected { get; set; }
    }
}