using Abp.Domain.Entities.Auditing;

namespace Yufu.Notify.Entities
{
  public class NotifyWeChatConfig : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }
  }
}