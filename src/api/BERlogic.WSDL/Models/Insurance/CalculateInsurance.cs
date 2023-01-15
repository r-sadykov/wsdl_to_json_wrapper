using BERlogic.WSDL.Common;
using BERlogic.WSDL.Enums;
using BERlogic.WSDL.Models.Bookings;

namespace BERlogic.WSDL.Models.Insurance
{
    /// <summary>
    /// Used in the <see cref="CalculateInsurance"/> method to send the request for calculation of the insurance cost.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "calculateInsurance", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class CalculateInsurance
    {
        /// <summary>
        /// The language in which information will be searched. Currently supported languages include "en", "de", "ru".
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lang", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lang;

        /// <summary>
        /// The series of the insurance policy.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 1)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "series", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Series;

        /// <summary>
        /// The booking object, for which the cost of the insurance policy of specified series should be calculated.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 2)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "booking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Booking Booking;

        /// <summary>
        /// Category of passenger
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 3)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "category", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PassengerCategory Category;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateInsurance"/> class.
        /// </summary>
        public CalculateInsurance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateInsurance"/> class.
        /// </summary>
        /// <param name="agent">The agent information.</param>
        /// <param name="series">The series of insurance policy.</param>
        /// <param name="booking">The booking object from previous requests.</param>
        /// <param name="category">The category of passenger.</param>
        public CalculateInsurance(BerlogicAgent agent, string series, Booking booking, PassengerCategory category)
        {
            this.Lang = agent.Lang;
            this.Series = series;
            this.Booking = booking;
            this.Category = category;
        }
    }
}