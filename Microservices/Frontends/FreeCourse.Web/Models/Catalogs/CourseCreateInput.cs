using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public decimal Price { get; set; }

        public string Picture { get; set; }

        public string UserId { get; set; }

        public FeatureViewModel Feature { get; set; }

        [Required]
        [Display(Name = "Kurs Kategori")]
        public string CategoryId { get; set; }

    }
}