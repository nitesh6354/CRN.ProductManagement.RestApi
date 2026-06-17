using Application.DTOs;

namespace Application.Interfaces.Services;

public interface IProductService
{
    Task<IEnumerable<ProductResponseDto>> GetAllAsync();

    Task<ProductResponseDto?> GetByIdAsync(int id);

    Task<int> CreateAsync(CreateProductDto dto);

    Task UpdateAsync(int id, UpdateProductDto dto);

    Task DeleteAsync(int id);
}