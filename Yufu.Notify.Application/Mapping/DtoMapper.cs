using AutoMapper;
using Yufu.Notify.Entities;
using Yufu.Notify.Shared.App.Dto;
using Yufu.Notify.Shared.WeChatTemplateData.Dto;

namespace Yufu.Notify.Mapping
{
  public static class DtoMapper
  {
    public static void Map()
    {
      Mapper.CreateMap<NotifyWeChatQueue, NotifyWeChatQueueDto>();
      Mapper.CreateMap<NotifyWeChatQueueDto, NotifyWeChatQueue>();

      Mapper.CreateMap<NotifyAppQueue, NotifyAppQueueDto>();
      Mapper.CreateMap<NotifyAppQueueDto, NotifyAppQueue>();
    }
  }
}