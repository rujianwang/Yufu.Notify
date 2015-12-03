using Abp.Dependency;
using Quartz;
using Yufu.Notify.Services;
using Yufu.Notify.Services.IServices;

namespace Yufu.Notify.Jobs
{
  public class PushJob:IJob
  {
    private readonly IAppAppService _appAppService;

    public PushJob()
    {
      _appAppService = IocManager.Instance.IocContainer.Resolve<IAppAppService>();
    }


    public void Execute(IJobExecutionContext context)
    {
      throw new System.NotImplementedException();
    }

  }
}