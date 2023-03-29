using FreeCourse.Shared.Dtos;
using IdentityModel.Client;

namespace FreeCourse.Web.Services.IdentityService
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn();
        Task<TokenResponse> GetAccessTokenByRefreshToken();
        Task RevokeRefreshToken();
    }
}
