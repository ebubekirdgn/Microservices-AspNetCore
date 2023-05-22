using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Discount.Services
{
    public interface IDiscountService
    {
<<<<<<< HEAD
        Task<Response<List<Models.Discount>>> GetAll();

        Task<Response<Models.Discount>> GetById(int id);

        Task<Response<NoContent>> Save(Models.Discount discount);

        Task<Response<NoContent>> Update(Models.Discount discount);

        Task<Response<NoContent>> Delete(int id);

        Task<Response<Models.Discount>> GetByCodeAndUserId(string code, string userId);
=======
        Task<Response<List<Model.Discount>>> GetAll();

        Task<Response<Model.Discount>> GetById(int id);

        Task<Response<NoContent>> Save(Model.Discount discount);

        Task<Response<NoContent>> Update(Model.Discount discount);

        Task<Response<NoContent>> Delete(int id);

        Task<Response<Model.Discount>> GetByCodeAndUserId(string code, string userId);
>>>>>>> main
    }
}