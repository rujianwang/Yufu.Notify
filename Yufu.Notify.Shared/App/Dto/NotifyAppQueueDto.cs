namespace Yufu.Notify.Shared.App.Dto
{
  public class NotifyAppQueueDto
  {
    public int NotifyApplicationId { get; set; }

    public string AppId { get; set; }

    public PushType PushType { get; set; }

    public string Platforms { get; set; }

    public string List { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }
  }

  public enum PushType : byte
  {
    SoftToken = 1,
    UserId = 2,
    AppId = 3
  }
}