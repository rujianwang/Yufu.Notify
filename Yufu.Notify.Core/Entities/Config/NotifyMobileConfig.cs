using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Yufu.Notify.Entities
{
  public class NotifyMobileConfig : FullAuditedEntity
  {
    public int NotifyApplicationId { get; set; }

    public MobileProvide MobileProvide { get; set; }

    [MaxLength(255)]
    public string Url { get; set; }

    [MaxLength(100)]
    public string UserName { get; set; }

    [MaxLength(200)]
    public string Password { get; set; }

    [MaxLength(100)]
    public string RequestHeadersIdKey { get; set; }

    [MaxLength(150)]
    public string RequestHeadersIdValue { get; set; }

    [MaxLength(100)]
    public string RequestHeadersKeyName { get; set; }

    [MaxLength(150)]
    public string RequestHeadersKeyValue { get; set; }
  }

  public enum MobileProvide : byte
  {
    Leancloud = 0,
  }
}