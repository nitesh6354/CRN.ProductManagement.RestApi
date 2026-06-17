using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Data.Repositories;

public class ProductRepository
    : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context)
        : base(context)
    {
    }
}