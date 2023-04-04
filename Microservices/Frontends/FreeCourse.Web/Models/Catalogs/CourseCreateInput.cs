using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseCreateInput
    {
        public string UserId { get; set; }

        [Display(Name = "Kurs Kategori")]
        [Required]
        public string CategoryId { get; set; }

        [Display(Name = "Kurs İsmi")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Kurs Açıklama")]
        [Required]
        public string Description { get; set; }

        public string Picture { get; set; }

        [Display(Name = "Kurs Ücreti (₺) ")]
        [Required]
        public decimal Price { get; set; }

        public FeatureViewModel Feature { get; set; }
    }
}