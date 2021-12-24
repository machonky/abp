// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Identity;
using Volo.Abp.Users;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.Identity.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IIdentityUserLookupAppService), typeof(IdentityUserLookupClientProxy))]
public partial class IdentityUserLookupClientProxy : ClientProxyBase<IIdentityUserLookupAppService>, IIdentityUserLookupAppService
{
    public virtual async Task<UserData> FindByIdAsync(Guid id)
    {
        return await RequestAsync<UserData>(nameof(FindByIdAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<UserData> FindByUserNameAsync(string userName)
    {
        return await RequestAsync<UserData>(nameof(FindByUserNameAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), userName }
        });
    }

    public virtual async Task<ListResultDto<UserData>> SearchAsync(UserLookupSearchInputDto input)
    {
        return await RequestAsync<ListResultDto<UserData>>(nameof(SearchAsync), new ClientProxyRequestTypeValue
        {
            { typeof(UserLookupSearchInputDto), input }
        });
    }

    public virtual async Task<long> GetCountAsync(UserLookupCountInputDto input)
    {
        return await RequestAsync<long>(nameof(GetCountAsync), new ClientProxyRequestTypeValue
        {
            { typeof(UserLookupCountInputDto), input }
        });
    }
}
