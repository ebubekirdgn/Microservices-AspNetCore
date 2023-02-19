using FreeCoure.Services.Basket.Dtos;
using FreeCourse.Shared.Dtos;

namespace FreeCoure.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasketAsync(string userId);

        Task<Response<bool>> SaveOrUpdateAsync(BasketDto basketDto);

        Task<Response<bool>> DeleteAsync(string userId);
    }
} 