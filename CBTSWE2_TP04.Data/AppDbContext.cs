// DUPLA:
// Adriano Junior de Souza Almeida
// Arthur Lanzilotti Farjanes

using Microsoft.EntityFrameworkCore;
using CBTSWE2_TP04.Models;

namespace CBTSWE2_TP04.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}