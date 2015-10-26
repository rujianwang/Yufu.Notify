using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Yufu.Notify.Enums;
using Yufu.Notify.Shared.App.Dto;

namespace Yufu.Notify.Entities
{
  public class NotifyAppQueue : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }

    [MaxLength(50)]
    public string AppId { get; set; }

    public PushType PushType { get; set; }

    public string Platforms { get; set; }

    public string List { get; set; }

    [MaxLength(500)]
    public string Title { get; set; }

    [MaxLength(1000)]
    public string Body { get; set; }

    public QueueStatus QueueStatus { get; set; }

    [MaxLength(50)]
    public string QueueStatusCode { get; set; }
  }
}