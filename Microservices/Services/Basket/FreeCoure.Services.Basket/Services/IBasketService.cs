﻿using FreeCoure.Services.Basket.Dtos;
using FreeCourse.Shared.Dtos;

namespace FreeCoure.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> Delete(string userId);
    }
}