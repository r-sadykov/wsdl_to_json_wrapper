using BERlogic.WSDL.Models.Bookings;
using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Models.Airlines
{
    /// <remarks/>
    /// <summary>
    /// The result of update passenger information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class UpdatePassengerResult
    {
        /// <remarks/>
        /// <summary>
        /// А booking object (same object structure as also used for the request) or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "booking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Booking Booking { get; set; }

        /// <remarks/>
        /// <summary>
        /// The cost of changes in passenger information.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "costOfChanges", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public CostOfChanges CostOfChanges { get; set; }
    }
}