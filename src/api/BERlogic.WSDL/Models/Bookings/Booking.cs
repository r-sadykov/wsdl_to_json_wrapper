using BERlogic.WSDL.Common;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Insurance;
using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Models.Bookings
{
    /// <remarks/>
    /// <summary>
    /// Extension for <see cref="BookingBase"/>.
    /// Contains booking information.
    /// This type is also used as a base for many other types:
    /// <para><see cref="CalculateInsurance"/></para>
    /// <see cref="CancelReservation"/>
    /// <para><see cref="CancelReservationResponse"/></para>
    /// <see cref="CheckPricing"/>
    /// <para><see cref="CheckPricingResponse"/></para>
    /// <see cref="CreateReservation"/>
    /// <para><see cref="CreateReservationResponse"/></para>
    /// <see cref="FinishBooking"/>
    /// <para><see cref="FinishBookingResponse"/></para>
    /// <see cref="IssuePolicyResponse"/>
    /// <para><see cref="Payment.Payment"/></para>
    /// <see cref="PreparePayment"/>
    /// <para><see cref="PreparePaymentResponse"/></para>
    /// <see cref="RefundPolicyResponse"/>
    /// <para><see cref="ReversePolicyResponse"/></para>
    /// <see cref="SearchRemarks"/>
    /// <para><see cref="SendEmail"/></para>
    /// <see cref="SendEmailResponse"/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://partner.v3.webservice.test.de/")] //DevSkim: ignore DS137138
    public partial class Booking : BookingBase
    {
        /// <remarks/>
        /// <summary>
        /// Cancellation error type information. As an example, see cancelReservationRS_error.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "failedCancellationInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string FailedCancellationInfo { get; set; }

        /// <remarks/>
        /// <summary>
        /// The list of services that are included in the booking. May occur one or more times.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("services", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public BERlogic.WSDL.Services.Service[] Services { get; set; }
    }
}