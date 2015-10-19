using Abp.Application.Services;
using Abp.Domain.Repositories;
using Yufu.Notify.Entities;

namespace Yufu.Notify.Services
{
  public interface IApplicationAppSevice : IApplicationService
  {
    #region Application

    NotifyApplication Get(int id);
    void Save(NotifyApplication entity);
    void Delete(int id);

    #endregion
  }
}