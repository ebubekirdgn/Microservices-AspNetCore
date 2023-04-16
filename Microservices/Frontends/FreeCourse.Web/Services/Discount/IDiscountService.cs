using FreeCourse.Web.Models.Discounts;

namespace FreeCourse.Web.Services.Discount
{
    public interface IDiscountService
    {
        Task<DiscountViewModel> GetDiscount(string discountCode);
    }
}
