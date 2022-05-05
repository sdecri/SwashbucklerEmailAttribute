using System.ComponentModel.DataAnnotations;

namespace SwashbucklerEmailAttribute.Models
{

  public class SendEmailRequest
  {
    protected const int MAX_RECIPIENTS = 10000;

    [Required]
    [MaxLength(MAX_RECIPIENTS)]
    [EmailAddress]
    public string[] recipients { get; set; }

    [EmailAddress]
    public string from { get; set; }

  }

}
