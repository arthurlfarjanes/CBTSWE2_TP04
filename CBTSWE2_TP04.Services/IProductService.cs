// DUPLA:
// Adriano Junior de Souza Almeida
// Arthur Lanzilotti Farjanes

using CBTSWE2_TP04.Models;

namespace CBTSWE2_TP04.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task<Product> AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
}