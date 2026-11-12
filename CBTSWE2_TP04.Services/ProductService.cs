// DUPLA:
// Adriano Junior de Souza Almeida
// Arthur Lanzilotti Farjanes

using CBTSWE2_TP04.Models;
using CBTSWE2_TP04.Repositories;

namespace CBTSWE2_TP04.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Product> AddAsync(Product product)
    {
        return await _repository.AddAsync(product);
    }

    public async Task UpdateAsync(Product product)
    {
        await _repository.UpdateAsync(product);
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _repository.GetByIdAsync(id);
        if (product != null)
        {
            await _repository.DeleteAsync(product);
        }
    }
}