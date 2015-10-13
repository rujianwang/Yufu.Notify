using Abp.Domain.Entities.Auditing;

namespace Yufu.Notify.Entities
{
  public class NotifyAppConfig : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }


  }
}