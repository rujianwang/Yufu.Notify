using Abp.Domain.Repositories;
using Yufu.Notify.Entities;

namespace Yufu.Notify.Services
{
  public class ApplicationAppSevice : NotifyAppServiceBase, IApplicationAppSevice
  {
    private readonly IRepository<NotifyApplication> _notifyApplicationRepository;

    public ApplicationAppSevice(IRepository<NotifyApplication> notifyApplicationRepository)
    {
      _notifyApplicationRepository = notifyApplicationRepository;
    }


    #region NotifyApplication

    public NotifyApplication Get(int id)
    {
      return _notifyApplicationRepository.FirstOrDefault(id);
    }

    public void Save(NotifyApplication entity)
    {
      _notifyApplicationRepository.InsertOrUpdate(entity);
    }

    public void Delete(int id)
    {
      _notifyApplicationRepository.Delete(id);
    } 

    #endregion
  }
}