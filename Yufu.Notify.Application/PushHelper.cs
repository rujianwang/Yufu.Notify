using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Yufu.Notify
{
  public class PushHelper
  {
    public static string SendByUserIds(string authtoken, string email, string appId, string title, string body, string userIds)
    {
      var stringBuilder = new StringBuilder();
      stringBuilder.Append("authtoken=" + authtoken);
      stringBuilder.Append("&email=" + email);
      stringBuilder.Append("&appId=" + appId);
      stringBuilder.Append("&platform=1");
      stringBuilder.Append("&userIdListStr=" + userIds);
      stringBuilder.Append("&title=" + title);
      stringBuilder.Append("&body=" + body);
      return SendHttpsPost(PushUrl + "sendByUid", stringBuilder.ToString());
    }

    public static string SendBySoftTokens(string authtoken, string email, string appId, string title, string body, string platform, string softTokens)
    {
      var stringBuilder = new StringBuilder();
      stringBuilder.Append("authtoken=" + authtoken);
      stringBuilder.Append("&email=" + email);
      stringBuilder.Append("&appId=" + appId);
      stringBuilder.Append("&platform=" + platform);
      stringBuilder.Append("&softTokenListStr=" + softTokens);
      stringBuilder.Append("&title=" + title);
      stringBuilder.Append("&body=" + body);
      return SendHttpsPost(PushUrl + "sendBySoftToken", stringBuilder.ToString());
    }

    public static string SendByAppId(string authtoken, string email, string appId, string title, string body, string platform = "0,1")
    {
      var stringBuilder = new StringBuilder();
      stringBuilder.Append("authtoken=" + authtoken);
      stringBuilder.Append("&email=" + email);
      stringBuilder.Append("&appId=" + appId);
      stringBuilder.Append("&platform=" + platform);
      stringBuilder.Append("&title=" + title);
      stringBuilder.Append("&body=" + body);
      return SendHttpsPost(PushUrl + "send", stringBuilder.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="url"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    private static string SendHttpsPost(string url, string param)
    {
      var request =
        WebRequest.Create(url)
        as HttpWebRequest;
      request.Method = "POST";
      request.UserAgent = "Mozilla/4.0";
      request.ContentType = "application/x-www-form-urlencoded";
      byte[] data = Encoding.UTF8.GetBytes(param);
      using (Stream stream = request.GetRequestStream())
      {
        stream.Write(data, 0, data.Length);
      }
      string responseFromServer;
      using (var response = request.GetResponse() as HttpWebResponse)
      {
        using (var reader = new StreamReader(response.GetResponseStream()))
        {
          responseFromServer = reader.ReadToEnd();
        }
      }
      var json = JsonConvert.DeserializeObject<PushJson>(responseFromServer);
      return json.status;
    }

    public static string PushUrl
    {
      get { return "http://newpush.appcan.cn/oauth/"; }
    }
  }

  public class PushJson
  {
    public string info { get; set; }
    public string status { get; set; }
  }
}