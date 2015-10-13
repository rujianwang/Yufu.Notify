using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Yufu.Notify.Entities
{
  public class NotifyApplication : FullAuditedEntity
  {
    [MaxLength(100)]
    public string Title { get; set; }
  }
}