namespace BERlogic.WSDL.Models.Airlines
{
    /// <summary>
    /// Used in the <see cref="SearchSchedule"/> method to get the response.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchScheduleResponse", WrapperNamespace = "http://partner.v3.webservice.test.de/", IsWrapped = true)] //DevSkim: ignore DS137138
    public partial class SearchScheduleResponse
    {
        /// <summary>
        /// А list of flights that satisfy the search request or – in case of an error – an exception or a security exception.
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://partner.v3.webservice.test.de/", Order = 0)] //DevSkim: ignore DS137138
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ScheduleElement[] ScheduleElements;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchScheduleResponse"/> class.
        /// </summary>
        public SearchScheduleResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchScheduleResponse"/> class.
        /// </summary>
        /// <param name="scheduleElements">The schedule elements.</param>
        public SearchScheduleResponse(ScheduleElement[] scheduleElements)
        {
            this.ScheduleElements = scheduleElements;
        }
    }
}