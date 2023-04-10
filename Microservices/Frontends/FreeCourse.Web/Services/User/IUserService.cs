using FreeCourse.Web.Models;

namespace FreeCourse.Web.Services.User
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}