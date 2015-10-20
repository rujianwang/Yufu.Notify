using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Yufu.Notify
{
    [DependsOn(typeof(AbpWebApiModule), typeof(NotifyApplicationModule))]
    public class NotifyWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //DynamicApiControllerBuilder
            //    .ForAll<IApplicationService>(typeof(NotifyApplicationModule).Assembly, "app")
            //    .Build();

            DynamicApiControllerBuilder
                .For<IWebApiAppService>("notify/appservice")
                .WithConventionalVerbs()
                .Build();
        }
    }
}
