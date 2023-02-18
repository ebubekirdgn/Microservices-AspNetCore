using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        // Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);

        Task<Response<CategoryDto>> GetByIdAsync(string id);

        Task<Response<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto);

        Task<Response<NoContent>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);

        Task<Response<NoContent>> DeleteAsync(string id);
    }
}