using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Yufu.Notify.Entities
{
  public class NotifyWeChatConfig : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }

    [MaxLength(50)]
    public string AppId { get; set; }

    [MaxLength(64)]
    public string Appsecret { get; set; }
  }
}