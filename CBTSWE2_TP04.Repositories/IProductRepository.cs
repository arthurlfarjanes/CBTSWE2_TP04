// DUPLA:
// Adriano Junior de Souza Almeida
// Arthur Lanzilotti Farjanes

using CBTSWE2_TP04.Models;

namespace CBTSWE2_TP04.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task<Product> AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
}