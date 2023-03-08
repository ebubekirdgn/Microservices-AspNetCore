using FreeCourse.Web.Models;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IUserService
    {
        public Task<UserViewModel> GetUser();
    }
}