using System.Threading.Tasks;
using vOpenUy.Demo.Configuration.Dto;

namespace vOpenUy.Demo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
