using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Yufu.Notify.Entities
{
  public class NotifyEmailConfig : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }

    [MaxLength(100)]
    public string Smtp { get; set; }

    [MaxLength(255)]
    public string Email { get; set; }

    [MaxLength(150)]
    public string Password { get; set; }

    [MaxLength(150)]
    public string SendUserName { get; set; }

    public int Port { get; set; }

    public bool EnableSsl { get; set; }
  }
}