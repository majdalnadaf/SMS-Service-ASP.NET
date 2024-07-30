using Microsoft.Extensions.Options;
using SMSApiServices.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SMSApiServices.Services
{
    public class ClsSMSServices : ISMSServices
    {

        private readonly TwilioSettingsModel _twilio;
        public ClsSMSServices(IOptions<TwilioSettingsModel> twilio)
        {
            _twilio = twilio.Value;
        }
        public MessageResource SendSMS(string phoneNumber, string body)
        {
            TwilioClient.Init(_twilio.AccountSID , _twilio.AuthToken);


            var oSMSResult = MessageResource.Create(
                body: body,
                from: new Twilio.Types.PhoneNumber(_twilio.PhoneNumber),
                to:phoneNumber
                ); 

            return oSMSResult;  
        }
    }
}
