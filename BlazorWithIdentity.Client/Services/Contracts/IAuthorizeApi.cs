using BlazorWithIdentity.Shared;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task<UserInfo> Login(LoginParameters loginParameters);

        Task<UserInfo> Register(RegisterParameters registerParameters);

        Task Logout();

        Task<UserInfo> GetUserInfo();
    }
}