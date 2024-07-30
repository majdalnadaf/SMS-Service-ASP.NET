using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSApiServices.DataTransferObjects;
using SMSApiServices.Services;

namespace SMSApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSServicesController : ControllerBase
    {
        private readonly ISMSServices clsSMSServices;
        public SMSServicesController(ISMSServices oSMSServices)
        {
                clsSMSServices = oSMSServices;
        }

        [HttpPost("SendSMS")]
        public IActionResult SendSMS(DTOSMS model)
        {
            try
            {

                var oResult = clsSMSServices.SendSMS(model.PhontNumber, model.body);
                if (!string.IsNullOrEmpty(oResult.ErrorMessage))
                {
                    return BadRequest(oResult.ErrorMessage);
                }

                return Ok(oResult);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
