using System.ComponentModel.DataAnnotations;

namespace SwashbucklerEmailAttribute.Models
{

  public interface IIdentifiers
  {
    public string[] recipients { get; set; }
    public string from { get; set; }
  }

  public class SendEmailRequest : IIdentifiers
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
