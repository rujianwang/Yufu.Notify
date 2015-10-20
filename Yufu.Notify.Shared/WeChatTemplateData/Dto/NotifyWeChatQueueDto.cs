namespace Yufu.Notify.Shared.WeChatTemplateData.Dto
{
  public class NotifyWeChatQueueDto
  {
    public int NotifyApplicationId { get; set; }
    public string OpenId { get; set; }
    public string TemplateId { get; set; }
    public string Body { get; set; }
  }
}