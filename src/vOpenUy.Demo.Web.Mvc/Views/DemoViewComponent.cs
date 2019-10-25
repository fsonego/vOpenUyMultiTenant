using Abp.AspNetCore.Mvc.ViewComponents;

namespace vOpenUy.Demo.Web.Views
{
    public abstract class DemoViewComponent : AbpViewComponent
    {
        protected DemoViewComponent()
        {
            LocalizationSourceName = DemoConsts.LocalizationSourceName;
        }
    }
}
