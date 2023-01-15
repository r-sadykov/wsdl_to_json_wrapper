using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

using BERlogic.WSDL.Common;
using BERlogic.WSDL.Interfaces;
using BERlogic.WSDL.Models.AeroExpress;
using BERlogic.WSDL.Models.Agencies;
using BERlogic.WSDL.Models.Airlines;
using BERlogic.WSDL.Models.Bookings;
using BERlogic.WSDL.Models.Insurance;
using BERlogic.WSDL.Models.Passengers;
using BERlogic.WSDL.Models.Payment;

namespace BERlogic.WSDL.Client
{
    /// <summary>
    /// Common client
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class BERlogicClient : System.ServiceModel.ClientBase<IBerlogicServices>, IBerlogicServices
    {
        /// <summary>
        /// The method to configure the service endpoint with given credentials.
        /// /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        /// <summary>
        /// Initializes a new instance of the <see cref="BERlogicClient"/> class.
        /// </summary>
        /// <remarks>
        /// We use this constructor if we have external endpoint URL and credentials for agent
        /// </remarks>
        /// <param name="endpointUrl">The endpoint URL that used to get access for external services.</param>
        /// <param name="timeout">The timeout that required to set wait time for responce from external services.</param>
        /// <param name="agent">The agent credential information that described in <see cref="BerlogicAgent"/></param>
        public BERlogicClient(string endpointUrl, TimeSpan timeout, BerlogicAgent agent) :
                base(BERlogicClient.GetBindingForEndpoint(timeout), BERlogicClient.GetEndpointAddress(endpointUrl))
        {
            this.ChannelFactory.Credentials.UserName.UserName = agent.AgentCode;
            this.ChannelFactory.Credentials.UserName.Password = agent.AgentPassword;
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BERlogicClient"/> class.
        /// </summary>
        /// <remarks>
        /// Basic construction for WSDL client to get access to BERlogic's services. Use basic parameters without usage of Channel with Agent credentials
        /// </remarks>
        /// <param name="endpointUrl">The endpoint URL that used to get access for external services.</param>
        /// <param name="timeout">The timeout that required to set wait time for responce from external services.</param>
        public BERlogicClient(string endpointUrl, TimeSpan timeout) :
                base(BERlogicClient.GetBindingForEndpoint(timeout), new System.ServiceModel.EndpointAddress(endpointUrl))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BERlogicClient"/> class.
        /// </summary>
        /// <remarks>
        /// Basic construction for WSDL client based on System classes.
        /// </remarks>
        /// <param name="binding">Configure WSDL Internet Protocol channel</param>
        /// <param name="remoteAddress">Set remote endpoint address</param>
        public BERlogicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        /// <summary>
        /// Can be used to get the list of bookings that satisfy the booking search parameters.
        /// Do not use without specifying the booking search parameters.
        /// </summary>
        /// <param name="request">Request object based on <see cref="GetBookings"/></param>
        /// <returns>Response object as class <see cref="GetBookingsResponse"/> realization</returns>
        public System.Threading.Tasks.Task<GetBookingsResponse> GetBookingsAsync(GetBookings request)
        {
            return base.Channel.GetBookingsAsync(request);
        }

        /// <summary>
        /// Update the information of a specific booking and use a flag to control whether the information is retrieved from the GDS or from the BERlogic system.
        /// </summary>
        /// <param name="request">Request object based on <see cref="UpdateBooking"/> class</param>
        /// <returns>Response object as realization of <see cref="UpdateBookingResponse"/></returns>
        public System.Threading.Tasks.Task<UpdateBookingResponse> UpdateBookingAsync(UpdateBooking request)
        {
            return base.Channel.UpdateBookingAsync(request);
        }

        /// <summary>
        /// Can be used to get booking information. If tickets, insurance and other services issued, they will be in the response.
        /// The method getBooking additionally triggers a finishBooking attempt.
        /// </summary>
        /// <remarks>
        /// The method was depreciated <see cref="ObsoleteAttribute"/>
        /// </remarks>
        /// <param name="request">Request object based on <see cref="GetBooking"/> class</param>
        /// <returns>Response object as realization of <see cref="GetBookingResponse"/></returns>
        public System.Threading.Tasks.Task<GetBookingResponse> GetBookingAsync(GetBooking request)
        {
            return base.Channel.GetBookingAsync(request);
        }

        /// <summary>
        /// Can be used to get the booking documents (binary) from the BERlogic system.
        /// <para>The type of documents downloaded depends on the agency / sales point document settings. Normally these documents are delivered within <see cref="FinishBookingResponse"/>. The present method is used for repeated download.</para>
        /// Do not use without specifying the booking search parameters.
        /// </summary>
        /// <param name="request">Request object based on <see cref="GetReport"/> class.</param>
        /// <returns>Response object as realization of <see cref="GetReportResponse"/>.</returns>
        public System.Threading.Tasks.Task<GetReportResponse> GetReportAsync(GetReport request)
        {
            return base.Channel.GetReportAsync(request);
        }

        /// <summary>
        /// Can be used to add booking information into the BERlogic system for a booking created by the partner outside the system (for instance, during the exchange in the blue screen within aftersales process). The gds IDs for the request should be requested from your account manager.
        /// </summary>
        /// <param name="request">Request object based on <see cref="ImportBooking"/> class.</param>
        /// <returns>Response object as realization of <see cref="ImportBookingResponse"/>.</returns>
        public System.Threading.Tasks.Task<ImportBookingResponse> ImportBookingAsync(ImportBooking request)
        {
            return base.Channel.ImportBookingAsync(request);
        }

        /// <summary>
        /// Can be used to get basic booking information.
        /// Do not use without specifying the booking search parameters.
        /// </summary>
        /// <param name="request">Request object based on <see cref="GetBookingInfosFromReportDB"/> class.</param>
        /// <returns>Response object as realization of <see cref="GetBookingInfosFromReportDBResponse"/>.</returns>
        public System.Threading.Tasks.Task<GetBookingInfosFromReportDBResponse> GetBookingInfosFromReportDBAsync(GetBookingInfosFromReportDB request)
        {
            return base.Channel.GetBookingInfosFromReportDBAsync(request);
        }

        /// <summary>
        /// Opens channel to WSDL client connection.
        /// </summary>
        /// <returns>Response object as realization of <see cref="Task"/>.</returns>
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        /// <summary>
        /// Closes channel to WSDL client connection.
        /// </summary>
        /// <returns>Response object as realization of <see cref="Task"/>.</returns>
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        /// <summary>
        /// Channel binding for endpoint.
        /// </summary>
        /// <param name="timeout">The timeout that required to set wait time for responce from external services.</param>
        /// <returns>Active channel that used in WSDL connection as <see cref="Binding"/>.</returns>
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(TimeSpan timeout)
        {
            var httpsBinding = new BasicHttpsBinding();
            httpsBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            httpsBinding.Security.Mode = BasicHttpsSecurityMode.Transport;

            var integerMaxValue = int.MaxValue;
            httpsBinding.MaxBufferSize = integerMaxValue;
            httpsBinding.MaxReceivedMessageSize = integerMaxValue;
            httpsBinding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            httpsBinding.AllowCookies = true;
            httpsBinding.ReceiveTimeout = timeout;
            httpsBinding.SendTimeout = timeout;
            httpsBinding.OpenTimeout = timeout;
            httpsBinding.CloseTimeout = timeout;

            return httpsBinding;
        }

        /// <summary>
        /// Set endpoint address for HTTPS.
        /// </summary>
        /// <param name="endpointUrl">Endpoint URL.</param>
        /// <returns>Response object as realization of <see cref="EndpointAddress"/>.</returns>
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(string endpointUrl)
        {
            if (!endpointUrl.StartsWith("https://"))
            {
                throw new UriFormatException("The endpoint URL must start with https://.");
            }
            return new System.ServiceModel.EndpointAddress(endpointUrl);
        }

        /// <summary>
        /// Authenticates the partner.
        /// </summary>
        /// <remarks>
        /// The method was depreciated <see cref="ObsoleteAttribute"/>
        /// </remarks>
        /// <param name="request">Request object based on <see cref="Authenticate"/> class.</param>
        /// <returns>Response object as realization of <see cref="AuthenticateResponse"/>.</returns>
        public System.Threading.Tasks.Task<AuthenticateResponse> AuthenticateAsync(Authenticate request)
        {
            return base.Channel.AuthenticateAsync(request);
        }

        /// <summary>
        /// Required only for payment by credit card with the data input on the payment gateway site (e.g. SIRENA_CC_ONLINE). For other payment types, the method is optional.
        /// <para>If <see cref="PreparePayment"/> has been started, but <see cref="FinishBooking"/> is not finished for some reason, then money is returned to the client.</para>
        /// </summary>
        /// <param name="request">Request object based on <see cref="PreparePayment"/> class.</param>
        /// <returns>Response object as realization of <see cref="PreparePaymentResponse"/>.</returns>
        public System.Threading.Tasks.Task<PreparePaymentResponse> PreparePaymentAsync(PreparePayment request)
        {
            return base.Channel.PreparePaymentAsync(request);
        }

        /// <summary>
        /// It is the last step in the BERlogic Booking Process.
        /// <para>In case the booking was payed the ticketing will be done.All booking documents will be provided within the <see cref="FinishBooking"/> response and additionally sent to the end-user via the email address if it was specified in the corresponding field.</para>
        /// If <see cref="PreparePayment"/> has been started, but <see cref="FinishBooking"/> is not finished for some reason, then money is returned to the client.
        /// </summary>
        /// <param name="request">Request object based on <see cref="FinishBooking"/> class.</param>
        /// <returns>Response object as realization of <see cref="FinishBookingResponse"/>.</returns>
        public System.Threading.Tasks.Task<FinishBookingResponse> FinishBookingAsync(FinishBooking request)
        {
            return base.Channel.FinishBookingAsync(request);
        }

        /// <summary>
        /// Get an updated price and expected flight availability.
        /// <para>Using <see cref="CheckPricing"/> is only appropriate directly before calling the <see cref="CreateReservation"/> request, especially when the corresponding <see cref="SearchFlights"/> request may be out of date.</para>
        /// Method <see cref="CheckPricing"/> bypasses the cache, accessing directly the flight information provider.Because this may cause additional costs, <see cref="CheckPricing"/> shall be used in an appropriate sense.
        /// </summary>
        /// <param name="request">Request object based on <see cref="CheckPricing"/> class.</param>
        /// <returns>Response object as realization of <see cref="CheckPricingResponse"/>.</returns>
        public System.Threading.Tasks.Task<CheckPricingResponse> CheckPricingAsync(CheckPricing request)
        {
            return base.Channel.CheckPricingAsync(request);
        }

        /// <summary>
        /// Create a reservation.
        /// <para>In all cases, before calling a <see cref="CreateReservation"/> again (for the same passenger and flight), it is recommended to use the method <see cref="CancelReservation"/>. It should be done independently from timestamps or validity periods of the reservation, because in most cases a second reservation with the same parameters will not be accepted.</para>
        /// Some reservations may be without a time-stamp within which the reservation would be guaranteed. In such cases the time-stamp shows the current or even past date and time.
        /// </summary>
        /// <param name="request">Request object based on <see cref="CreateReservation"/> class.</param>
        /// <returns>Response object as realization of <see cref="CreateReservationResponse"/>.</returns>
        public System.Threading.Tasks.Task<CreateReservationResponse> CreateReservationAsync(CreateReservation request)
        {
            return base.Channel.CreateReservationAsync(request);
        }

        /// <summary>
        /// Searches the information about available seats in AeroExpress.
        /// </summary>
        /// <param name="request">Request object based on <see cref="SearchAeroexpressSeatInfo"/> class.</param>
        /// <returns>Response object as realization of <see cref="SearchAeroexpressSeatInfoResponse"/>.</returns>
        public System.Threading.Tasks.Task<SearchAeroexpressSeatInfoResponse> SearchAeroexpressSeatInfoAsync(SearchAeroexpressSeatInfo request)
        {
            return base.Channel.SearchAeroexpressSeatInfoAsync(request);
        }

        /// <summary>
        /// Can be used to refund the insurance manually.
        /// </summary>
        /// <param name="request">Request object based on <see cref="RefundPolicy"/> class.</param>
        /// <returns>Response object as realization of <see cref="RefundPolicyResponse"/>.</returns>
        public System.Threading.Tasks.Task<RefundPolicyResponse> RefundPolicyAsync(RefundPolicy request)
        {
            return base.Channel.RefundPolicyAsync(request);
        }

        /// <summary>
        /// Can be used to change the authorization password for an agent.
        /// </summary>
        /// <param name="request">Request object based on <see cref="ChangePassword"/> class.</param>
        /// <returns>Response object as realization of <see cref="ChangePasswordResponse"/>.</returns>
        public System.Threading.Tasks.Task<ChangePasswordResponse> ChangePasswordAsync(ChangePassword request)
        {
            return base.Channel.ChangePasswordAsync(request);
        }

        /// <summary>
        /// Can be used to cancel the insurance manually.
        /// </summary>
        /// <param name="request">Request object based on <see cref="ReversePolicy"/> class.</param>
        /// <returns>Response object as realization of <see cref="ReversePolicyResponse"/>.</returns>
        public System.Threading.Tasks.Task<ReversePolicyResponse> ReversePolicyAsync(ReversePolicy request)
        {
            return base.Channel.ReversePolicyAsync(request);
        }

        /// <summary>
        /// Can be used to get information about fare conditions.
        /// <para>Partners are NOT allowed to use this function for more than one single flight at a time. It must NEVER be used in bulk mode (e.g. requesting fare conditions for all flights of the result set returned).</para>
        /// </summary>
        /// <param name="request">Request object based on <see cref="SearchRemarks"/> class.</param>
        /// <returns>Response object as realization of <see cref="SearchRemarksResponse"/>.</returns>
        public System.Threading.Tasks.Task<SearchRemarksResponse> SearchRemarksAsync(SearchRemarks request)
        {
            return base.Channel.SearchRemarksAsync(request);
        }

        /// <summary>
        /// Initiates the booking process and serves as a base for further steps.
        /// Response times may vary depending on several factors (e.g. from cache or not).
        /// </summary>
        /// <param name="request">Request object based on <see cref="SearchFlights"/> class.</param>
        /// <returns>Response object as realization of <see cref="SearchFlightsResponse"/>.</returns>
        public System.Threading.Tasks.Task<SearchFlightsResponse> SearchFlightsAsync(SearchFlights request)
        {
            return base.Channel.SearchFlightsAsync(request);
        }

        /// <summary>
        /// Can be used for calculation the cost of the insurance policy.
        /// </summary>
        /// <param name="request">Request object based on <see cref="CalculateInsurance"/> class.</param>
        /// <returns>Response object as realization of <see cref="CalculateInsuranceResponse"/>.</returns>
        public System.Threading.Tasks.Task<CalculateInsuranceResponse> CalculateInsuranceAsync(CalculateInsurance request)
        {
            return base.Channel.CalculateInsuranceAsync(request);
        }

        /// <summary>
        /// Can be used to send the confirmation email.
        /// Resending itinerary receipts (MK), travel documents to email address.
        /// </summary>
        /// <param name="request">Request object based on <see cref="SendEmail"/> class.</param>
        /// <returns>Response object as realization of <see cref="SendEmailResponse"/>.</returns>
        public System.Threading.Tasks.Task<SendEmailResponse> SendEmailAsync(SendEmail request)
        {
            return base.Channel.SendEmailAsync(request);
        }

        /// <summary>
        /// Can be used to issue the insurance manually.
        /// In general, this method is not mandatory, because insurance will be issued in <see cref="FinishBooking"/>.
        /// </summary>
        /// <param name="request">Request object based on <see cref="IssuePolicy"/> class.</param>
        /// <returns>Response object as realization of <see cref="IssuePolicyResponse"/>.</returns>
        public System.Threading.Tasks.Task<IssuePolicyResponse> IssuePolicyAsync(IssuePolicy request)
        {
            return base.Channel.IssuePolicyAsync(request);
        }

        /// <summary>
        /// Can be used to get flight schedules.
        /// Rarely used, because the customer normally requests the flights with prices (<see cref="SearchFlights"/>).
        /// </summary>
        /// <param name="request">Request object based on <see cref="SearchSchedule"/> class.</param>
        /// <returns>Response object as realization of <see cref="SearchScheduleResponse"/>.</returns>
        public System.Threading.Tasks.Task<SearchScheduleResponse> SearchScheduleAsync(SearchSchedule request)
        {
            return base.Channel.SearchScheduleAsync(request);
        }

        /// <summary>
        /// Can be used to cancel a reservation.
        /// <para>Method <see cref="CancelReservation"/> can NOT be used to cancel a completed ticketed booking. That means that after the payment is done, <see cref="CancelReservation"/> will not work.</para>
        /// If a <see cref="CreateReservation"/> was performed, but the user does not continue (e.g.he is leaving the web site), calling <see cref="CancelReservation"/> is mandatory.In some special cases, when the server has no notification about the user leaving, this may not be possible to be performed. Otherwise a second booking attempt some hours later may fail, because there is already a reservation in the system. In most cases a second reservation with the same parameters (<see cref="Flight"/> and <see cref="Passenger"/>) is not possible.
        /// </summary>
        /// <param name="request">Request object based on <see cref="CancelReservation"/> class.</param>
        /// <returns>Response object as realization of <see cref="CancelReservationResponse"/>.</returns>
        public System.Threading.Tasks.Task<CancelReservationResponse> CancelReservationAsync(CancelReservation request)
        {
            return base.Channel.CancelReservationAsync(request);
        }

        /// <summary>
        /// Can be used to void tickets.
        /// <para>Can be used in conjunction with the WS Payment method to control money flow (e.g. retain a certain amount). In case of success, the price property of the payment object defines how much payment is still authorized.</para>
        /// Using of this method is advisable only if you implement a personal account for an operator. In general, tickets refund is not a simple procedure, because usually tickets are sold at non-refundable rate.
        /// </summary>
        /// <param name="request">Request object based on <see cref="VoidTickets"/> class.</param>
        /// <returns>Response object as realization of <see cref="VoidTicketsResponse"/>.</returns>
        public System.Threading.Tasks.Task<VoidTicketsResponse> VoidTicketsAsync(VoidTickets request)
        {
            return base.Channel.VoidTicketsAsync(request);
        }

        /// <summary>
        /// Updates the passenger information.
        /// </summary>
        /// <param name="request">Request object based on <see cref="UpdatePassenger"/> class.</param>
        /// <returns>Response object as realization of <see cref="UpdatePassengerResponse"/>.</returns>
        public System.Threading.Tasks.Task<UpdatePassengerResponse> UpdatePassengerAsync(UpdatePassenger request)
        {
            return base.Channel.UpdatePassengerAsync(request);
        }

        /// <summary>
        /// Searches information about trains that are available as AeroExpress.
        /// </summary>
        /// <param name="request">Request object based on <see cref="SearchAeroexpressTrainInfo"/> class.</param>
        /// <returns>Response object as realization of <see cref="SearchAeroexpressTrainInfoResponse"/>.</returns>
        public System.Threading.Tasks.Task<SearchAeroexpressTrainInfoResponse> SearchAeroexpressTrainInfoAsync(SearchAeroexpressTrainInfo request)
        {
            return base.Channel.SearchAeroexpressTrainInfoAsync(request);
        }
    }
}