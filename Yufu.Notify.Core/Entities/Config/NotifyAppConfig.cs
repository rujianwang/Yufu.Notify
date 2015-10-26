using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Yufu.Notify.Entities
{
  public class NotifyAppConfig : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }

    [MaxLength(100)]
    public string Authtoken { get; set; }

    [MaxLength(255)]
    public string Email { get; set; }



  }
}