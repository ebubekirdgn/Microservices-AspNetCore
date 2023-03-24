using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseCreateInput
    {
        [Display(Name = "Kurs İsmi")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Kurs Açıklama")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Kurs Fiyat")]
        [Range(0, double.MaxValue, ErrorMessage = "Kurs ücreti negatif olamaz")]
        public decimal Price { get; set; }

        public string Picture { get; set; }

        public string UserId { get; set; }

        public FeatureViewModel Feature { get; set; }

        [Required]
        [Display(Name = "Kurs Kategori")]
        public string CategoryId { get; set; }

        [Display(Name = "Kurs Resim")]
        public IFormFile PhotoFormFile { get; set; }
    }
}