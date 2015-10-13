using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Yufu.Notify.Enums;

namespace Yufu.Notify.Entities
{
  public class NotifyWeChatQueue : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }

    [MaxLength(100)]
    public string OpenId { get; set; }

    [MaxLength(100)]
    public string TemplateId { get; set; }

    [MaxLength(50)]
    public string TopColor { get; set; }

    [MaxLength(255)]
    public string Url { get; set; }

    public string Body { get; set; }

    public QueueStatus QueueStatus { get; set; }

    [MaxLength(50)]
    public string QueueStatusCode { get; set; }
  }
}