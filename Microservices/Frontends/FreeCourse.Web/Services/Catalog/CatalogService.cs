using FreeCourse.Web.Models.Catalogs;
using FreeCourse.Web.Services.Interfaces;

namespace FreeCourse.Web.Services.Catalog
{
    public class CatalogService : ICatalogService
    {
        public Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCourseAsync(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetAllCourseAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetAllCourseByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<CourseViewModel> GetByCourseId(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput)
        {
            throw new NotImplementedException();
        }
    }
}
