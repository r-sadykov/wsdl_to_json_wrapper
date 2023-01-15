namespace BERlogic.WSDL.Services
{
    /// <remarks>
    /// Abstract type.
    /// Empty sequence.
    /// </remarks>
    /// <summary>
    /// BERlogic service base class.
    /// <para>This type is used to describe additional services in the booking process and can be extended through types:</para>
    /// <para><see cref="AeroexpressTicket"/></para>
    /// <para><see cref="AirTicket"/></para>
    /// <para><see cref="HotelBooking"/></para>
    /// <para><see cref="Insurance"/></para>
    /// <para><see cref="SPZDBooking"/></para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SPZDBooking))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Insurance))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HotelBooking))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AeroexpressTicket))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AirTicket))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public abstract partial class Service
    {
    }
}