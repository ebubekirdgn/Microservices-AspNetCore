using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseUpdateInput
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Picture { get; set; }
        public decimal Price { get; set; }
        public FeatureViewModel Feature { get; set; }

        [Display(Name = "Kurs Resim")]
        public IFormFile PhotoFormFile { get; set; }
    }
}