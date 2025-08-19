using Microsoft.EntityFrameworkCore;
using Proyecto_CRUD.Models;

namespace Proyecto_CRUD.DataAcces;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<ContactoModel> Contactos{ get; set; }
}