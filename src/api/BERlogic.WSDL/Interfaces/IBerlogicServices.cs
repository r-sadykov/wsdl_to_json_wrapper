using BERlogic.WSDL.Common;
using BERlogic.WSDL.Exceptions;
using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Agencies;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Bookings;
using BERlogic.WSDL.Models.Insurance;
using BERlogic.WSDL.Models.Passengers;
using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Interfaces
{
    /// <summary>
    /// Interface that described common used method of BERlogic services.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://partner.v3.webservice.test.de/", ConfigurationName = "test")] //DevSkim: ignore DS137138
    public interface IBerlogicServices
    {
        /// <summary>
        /// Can be used to get the list of bookings that satisfy the booking search parameters.
        /// Do not use without specifying the booking search parameters.
        /// </summary>
        /// <param name="request">Request object of type <see cref="GetBookings"/></param>
        /// <returns>Returns object of type <see cref="GetBookingsResponse"/></returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResource))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookingBase))]
        System.Threading.Tasks.Task<GetBookingsResponse> GetBookingsAsync(GetBookings request);

        /// <summary>
        /// Update the information of a specific booking and use a flag to control whether the information is retrieved from the GDS or from the BERlogic system.
        /// </summary>
        /// <param name="request">Request object of type <see cref="UpdateBooking"/></param>
        /// <returns>Returns object of type <see cref="UpdateBookingResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceException), Action = "", Name = "ServiceException")]
        [System.ServiceModel.FaultContractAttribute(typeof(LocalizationException), Action = "", Name = "LocalizationException")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResource))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookingBase))]
        System.Threading.Tasks.Task<UpdateBookingResponse> UpdateBookingAsync(UpdateBooking request);

        /// <remarks>
        /// Method was depreciated.
        /// </remarks>
        /// <summary>
        /// Can be used to get booking information. If tickets, insurance and other services issued, they will be in the response.
        /// The method <see cref="GetBooking"/> additionally triggers a <see cref="FinishBooking"/> attempt.
        /// </summary>
        /// <param name="request">Request object of type <see cref="GetBooking"/></param>
        /// <returns>Returns object of type <see cref="GetBookingResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceException), Action = "", Name = "ServiceException")]
        [System.ServiceModel.FaultContractAttribute(typeof(LocalizationException), Action = "", Name = "LocalizationException")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResource))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookingBase))]
        System.Threading.Tasks.Task<GetBookingResponse> GetBookingAsync(GetBooking request);

        /// <summary>
        /// Can be used to get the booking documents (binary) from the BERlogic system.
        /// <para>The type of documents downloaded depends on the agency / sales point document settings. Normally these documents are delivered within <see cref="FinishBookingResponse"/>. The present method is used for repeated download.</para>
        /// Do not use without specifying the booking search parameters.
        /// </summary>
        /// <param name="request">Request object of type <see cref="GetReport"/></param>
        /// <returns>Returns object of type <see cref="GetReportResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResource))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookingBase))]
        System.Threading.Tasks.Task<GetReportResponse> GetReportAsync(GetReport request);

        /// <summary>
        /// Can be used to add booking information into the BERlogic system for a booking created by the partner outside the system (for instance, during the exchange in the blue screen within aftersales process). The gds IDs for the request should be requested from your account manager.
        /// </summary>
        /// <param name="request">Request object of type <see cref="ImportBooking"/></param>
        /// <returns>Returns object of type <see cref="ImportBookingResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceException), Action = "", Name = "ServiceException")]
        [System.ServiceModel.FaultContractAttribute(typeof(LocalizationException), Action = "", Name = "LocalizationException")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResource))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookingBase))]
        System.Threading.Tasks.Task<ImportBookingResponse> ImportBookingAsync(ImportBooking request);

        /// <summary>
        /// Can be used to get basic booking information from BERlogic's report tables in Database.
        /// Do not use without specifying the booking search parameters.
        /// </summary>
        /// <param name="request">Request object of type <see cref="GetBookingInfosFromReportDB"/></param>
        /// <returns>Returns object of type <see cref="GetBookingInfosFromReportDBResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResource))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookingBase))]
        System.Threading.Tasks.Task<GetBookingInfosFromReportDBResponse> GetBookingInfosFromReportDBAsync(GetBookingInfosFromReportDB request);

        /// <remarks>
        /// The method was depreciated.
        /// </remarks>
        /// <summary>
        /// Authenticates the partner.
        /// </summary>
        /// <param name="request">Request object of type <see cref="Authenticate"/>.</param>
        /// <returns>Returns object of type <see cref="AuthenticateResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceException), Action = "", Name = "ServiceException")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<AuthenticateResponse> AuthenticateAsync(Authenticate request);

        /// <summary>
        /// Required only for payment by credit card with the data input on the payment gateway site (e.g. SIRENA_CC_ONLINE). For other payment types, the method is optional.
        /// <para>If preparePayment has been started, but finishBooking is not finished for some reason, then money is returned to the client.</para>
        /// </summary>
        /// <param name="request">Request object of type <see cref="PreparePayment"/>.</param>
        /// <returns>Returns object of type <see cref="PreparePaymentResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceException), Action = "", Name = "ServiceException")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<PreparePaymentResponse> PreparePaymentAsync(PreparePayment request);

        /// <summary>
        /// It is the last step in the BERlogic Booking Process.
        /// <para>In case the booking was payed the ticketing will be done. All booking documents will be provided within the finishBooking response and additionally sent to the end-user via the email address if it was specified in the corresponding field.</para>
        /// If preparePayment has been started, but finishBooking is not finished for some reason, then money is returned to the client.
        /// </summary>
        /// <param name="request">Request object of type <see cref="FinishBooking"/>.</param>
        /// <returns>Returns object of type <see cref="FinishBookingResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<FinishBookingResponse> FinishBookingAsync(FinishBooking request);

        /// <summary>
        /// Get an updated price and expected flight availability.
        /// <para>Using <see cref="CheckPricing"/> is only appropriate directly before calling the <see cref="CreateReservation"/> request, especially when the corresponding <see cref="SearchFlights"/> request may be out of date.</para>
        /// Method <see cref="CheckPricing"/> bypasses the cache, accessing directly the flight information provider. Because this may cause additional costs, <see cref="CheckPricing"/> shall be used in an appropriate sense
        /// </summary>
        /// <param name="request">Request object of type <see cref="CheckPricing"/>.</param>
        /// <returns>Returns object of type <see cref="CheckPricingResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<CheckPricingResponse> CheckPricingAsync(CheckPricing request);

        /// <summary>
        /// Create a reservation.
        /// <para>In all cases, before calling a <see cref="CreateReservation"/> again(for the same passenger and flight), it is recommended to use the method <see cref="CancelReservation"/>. It should be done independently from timestamps or validity periods of the reservation, because in most cases a second reservation with the same parameters will not be accepted.</para>
        /// Some reservations may be without a time-stamp within which the reservation would be guaranteed. In such cases the time-stamp shows the current or even past date and time.
        /// </summary>
        /// <param name="request">Request object of type <see cref="CreateReservation"/>.</param>
        /// <returns>Returns object of type <see cref="CreateReservationResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<CreateReservationResponse> CreateReservationAsync(CreateReservation request);

        /// <summary>
        /// Searches the available seats in AeroExpress  train.
        /// </summary>
        /// <param name="request">Request object of type <see cref="SearchAeroexpressSeatInfo"/>.</param>
        /// <returns>Returns object of type <see cref="SearchAeroexpressSeatInfoResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<SearchAeroexpressSeatInfoResponse> SearchAeroexpressSeatInfoAsync(SearchAeroexpressSeatInfo request);

        /// <summary>
        /// Can be used to refund the insurance manually.
        /// </summary>
        /// <param name="request">Request object of type <see cref="RefundPolicy"/>.</param>
        /// <returns>Returns object of type <see cref="RefundPolicyResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<RefundPolicyResponse> RefundPolicyAsync(RefundPolicy request);

        /// <summary>
        /// Can be used to change the authorization password for an agent.
        /// </summary>
        /// <param name="request">Request object of type <see cref="ChangePassword"/>.</param>
        /// <returns>Returns object of type <see cref="ChangePasswordResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<ChangePasswordResponse> ChangePasswordAsync(ChangePassword request);

        /// <summary>
        /// Can be used to cancel the insurance manually.
        /// </summary>
        /// <param name="request">Request object of type <see cref="ReversePolicy"/>.</param>
        /// <returns>Returns object of type <see cref="ReversePolicyResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<ReversePolicyResponse> ReversePolicyAsync(ReversePolicy request);

        /// <summary>
        /// Can be used to get information about fare conditions.
        /// <para>Partners are NOT allowed to use this function for more than one single flight at a time. It must NEVER be used in bulk mode (e.g. requesting fare conditions for all flights of the result set returned).</para>
        /// </summary>
        /// <param name="request">Request object of type <see cref="SearchRemarks"/>.</param>
        /// <returns>Returns object of type <see cref="SearchRemarksResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<SearchRemarksResponse> SearchRemarksAsync(SearchRemarks request);

        /// <summary>
        /// Initiates the booking process and serves as a base for further steps.
        /// Response times may vary depending on several factors (e.g. from cache or not).
        /// </summary>
        /// <param name="request">Request object of type <see cref="SearchFlights"/>.</param>
        /// <returns>Returns object of type <see cref="SearchFlightsResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<SearchFlightsResponse> SearchFlightsAsync(SearchFlights request);

        /// <summary>
        /// Can be used for calculation the cost of the insurance policy.
        /// </summary>
        /// <param name="request">Request object of type <see cref="CalculateInsurance"/>.</param>
        /// <returns>Returns object of type <see cref="CalculateInsuranceResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceException), Action = "", Name = "ServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<CalculateInsuranceResponse> CalculateInsuranceAsync(CalculateInsurance request);

        /// <summary>
        /// Can be used to send the confirmation email.
        /// Resending itinerary receipts (MK), travel documents to email address.
        /// </summary>
        /// <param name="request">Request object of type <see cref="SendEmail"/>.</param>
        /// <returns>Returns object of type <see cref="SendEmailResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<SendEmailResponse> SendEmailAsync(SendEmail request);

        /// <summary>
        /// Can be used to issue the insurance manually.
        /// <para>In general, this method is not mandatory, because insurance will be issued in <see cref="FinishBooking"/>.</para>
        /// </summary>
        /// <param name="request">Request object of type <see cref="IssuePolicy"/>.</param>
        /// <returns>Returns object of type <see cref="IssuePolicyResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<IssuePolicyResponse> IssuePolicyAsync(IssuePolicy request);

        /// <summary>
        /// Can be used to get flight schedules.
        /// <para>Rarely used, because the customer normally requests the flights with prices (<see cref="SearchFlights"/>).</para>
        /// </summary>
        /// <param name="request">Request object of type <see cref="SearchSchedule"/>.</param>
        /// <returns>Returns object of type <see cref="SearchScheduleResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<SearchScheduleResponse> SearchScheduleAsync(SearchSchedule request);

        /// <summary>
        /// Can be used to cancel a reservation.
        /// <para>Method <see cref="CancelReservation"/> can NOT be used to cancel a completed ticketed booking.That means that after the payment is done, <see cref="CancelReservation"/> will not work.</para>
        /// If a <see cref="CreateReservation"/> was performed, but the user does not continue (e.g.he is leaving the web site), calling <see cref="CancelReservation"/> is mandatory. In some special cases, when the server has no notification about the user leaving, this may not be possible to be performed. Otherwise a second booking attempt some hours later may fail, because there is already a reservation in the system.
        /// <para>In most cases a second reservation with the same parameters (<see cref="Flight"/> and <see cref="Passenger"/>) is not possible.</para>
        /// </summary>
        /// <param name="request">Request object of type <see cref="CancelReservation"/>.</param>
        /// <returns>Returns object of type <see cref="CancelReservationResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<CancelReservationResponse> CancelReservationAsync(CancelReservation request);

        /// <summary>
        /// Can be used to void tickets.
        /// <para>Can be used in conjunction with the WS Payment method to control money flow(e.g.retain a certain amount). In case of success, the price property of the payment object defines how much payment is still authorized.</para>
        /// Using of this method is advisable only if you implement a personal account for an operator. In general, tickets refund is not a simple procedure, because usually tickets are sold at non-refundable rate.
        /// </summary>
        /// <param name="request">Request object of type <see cref="VoidTickets"/>.</param>
        /// <returns>Returns object of type <see cref="VoidTicketsResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<VoidTicketsResponse> VoidTicketsAsync(VoidTickets request);

        /// <summary>
        /// Updates the information about passenger.
        /// </summary>
        /// <param name="request">Request object of type <see cref="UpdatePassenger"/>.</param>
        /// <returns>Returns object of type <see cref="UpdatePassengerResponse"/>.</returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<UpdatePassengerResponse> UpdatePassengerAsync(UpdatePassenger request);

        /// <summary>
        /// Searches the information about available AeroExpress train.
        /// </summary>
        /// <param name="request">Request object of type <see cref="SearchAeroexpressTrainInfo"/>.</param>
        /// <returns>Returns object of type <see cref="SearchAeroexpressTrainInfoResponse"/></returns>
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityException), Action = "", Name = "SecurityException")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exceptions.Exception), Action = "", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SalesPoint))]
        System.Threading.Tasks.Task<SearchAeroexpressTrainInfoResponse> SearchAeroexpressTrainInfoAsync(SearchAeroexpressTrainInfo request);
    }
}