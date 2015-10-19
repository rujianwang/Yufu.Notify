using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;

namespace Yufu.Notify.Shared.WeChatTemplateData
{
  /// <summary>
  /// 
  /// </summary>
  public class NewBid : BaseTemplateData
  {

    /// <summary>
    /// 竞价物
    /// </summary>
    public TemplateDataItem keyword1 { get; set; }

    /// <summary>
    /// 发起方
    /// </summary>
    public TemplateDataItem keyword2 { get; set; }

    /// <summary>
    /// 截止时间
    /// </summary>
    public TemplateDataItem keyword3 { get; set; }
  }
}