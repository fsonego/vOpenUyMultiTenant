using Abp.AutoMapper;
using vOpenUy.Demo.Authentication.External;

namespace vOpenUy.Demo.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
