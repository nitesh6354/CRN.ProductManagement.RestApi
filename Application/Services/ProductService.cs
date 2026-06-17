using Application.DTOs;
using Application.Interfaces.Services;

namespace Application.Services;

public class ProductService : IProductService
{
    public Task<int> CreateAsync(CreateProductDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductResponseDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductResponseDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int id, UpdateProductDto dto)
    {
        throw new NotImplementedException();
    }
}