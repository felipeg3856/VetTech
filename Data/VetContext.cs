using Microsoft.EntityFrameworkCore;
using VetTechApi.Models;
namespace VetTechApi.Data;

    public class VetContext : DbContext
{

    public VetContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Consulta> Consultas { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Tutor> Tutores { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
}

