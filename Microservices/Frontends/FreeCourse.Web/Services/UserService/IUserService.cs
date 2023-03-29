using FreeCourse.Web.Models;

namespace FreeCourse.Web.Services.UserService
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}
