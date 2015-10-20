using System;
using System.IO;
using System.Text;
using Senparc.Weixin;
using Senparc.Weixin.CommonAPIs;
using Senparc.Weixin.Exceptions;
using Senparc.Weixin.Helpers;
using Senparc.Weixin.HttpUtility;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;

namespace Yufu.Notify.Application
{
  public static class YufuWeChatHelper
  {
    public static T Send<T>(string accessToken, string urlFormat, string jsonString,
      CommonJsonSendType sendType = CommonJsonSendType.POST, int timeOut = Config.TIME_OUT,
      bool checkValidationResult = false, JsonSetting jsonSetting = null)
    {
      try
      {
        var url = string.IsNullOrEmpty(accessToken) ? urlFormat : string.Format(urlFormat, accessToken);
        switch (sendType)
        {
          case CommonJsonSendType.GET:
            return Get.GetJson<T>(url);
          case CommonJsonSendType.POST:
            using (MemoryStream ms = new MemoryStream())
            {
              var bytes = Encoding.UTF8.GetBytes(jsonString);
              ms.Write(bytes, 0, bytes.Length);
              ms.Seek(0, SeekOrigin.Begin);

              return Post.PostGetJson<T>(url, null, ms, timeOut: timeOut, checkValidationResult: checkValidationResult);
            }

            //TODO:对于特定的错误类型自动进行一次重试，如40001（目前的问题是同样40001会出现在不同的情况下面）
          default:
            throw new ArgumentOutOfRangeException("sendType");
        }
      }
      catch (ErrorJsonResultException ex)
      {
        ex.Url = urlFormat;
        throw;
      }
    }

    public static SendTemplateMessageResult SendTemplateMessage(string accessTokenOrAppId, string msgData, int timeOut = Config.TIME_OUT)
    {
      return ApiHandlerWapper.TryCommonApi(accessToken =>
      {
        const string urlFormat = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token={0}";
        return Send<SendTemplateMessageResult>(accessToken, urlFormat, msgData, timeOut: timeOut);

      }, accessTokenOrAppId);
    }
  }
}