﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using vOpenUy.Demo.Configuration.Dto;

namespace vOpenUy.Demo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
