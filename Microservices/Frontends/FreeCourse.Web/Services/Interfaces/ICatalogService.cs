using FreeCourse.Web.Models.Catalogs;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface ICatalogService
    {
        Task<List<CourseViewModel>> GetAllCourseAsync();
        Task<List<CourseViewModel>> GetAllCourseByUserIdAsync(string userId);
        
        Task<CourseViewModel> GetByCourseId(string courseId);
        Task<bool> DeleteCourseAsync(string courseId);


    }
}
