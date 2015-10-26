using Abp.Application.Services;
using Yufu.Notify.Entities;
using Yufu.Notify.Shared.App.Dto;

namespace Yufu.Notify.Services.IServices
{
  public interface IAppAppService : IApplicationService
  {
    NotifyAppConfig ConfigGet(int applicationId);

    void QueueSave(NotifyAppQueue entity);
    NotifyAppQueue QueueGet(int id);
    void QueueDelete(int id);

    void Push(NotifyAppQueue entity);


  }
}