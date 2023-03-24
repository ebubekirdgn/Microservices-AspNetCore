using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Catalogs
{
    public class FeatureViewModel
    {
        [Display(Name = "Kurs süre")]

        [Range(0, double.MaxValue, ErrorMessage = "Kurs süresi negatif olamaz")]
        public int Duration { get; set; }
    }
}