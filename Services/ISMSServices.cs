


using Twilio.Rest.Api.V2010.Account;

namespace SMSApiServices.Services
{
    public interface ISMSServices
    {
        MessageResource SendSMS(string phoneNumber, string body);

    }
}
