using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using SwashbucklerEmailAttribute.Models;

namespace SwashbucklerEmailAttribute.Controllers
{
  [ApiController]
  [Route("email-service")]
  public class EmailController : ControllerBase
  {

    const long MAX_ATTACHMENT_SIZE = 5242880;

    private readonly ILogger<EmailController> _logger;


    [HttpPost("send-email")]
    public IActionResult SendEmailAsync([FromForm] SendEmailRequest req)
    {

      _logger.LogInformation(req.ToJson());
      return Ok();
    }


  }
}
