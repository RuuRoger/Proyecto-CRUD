using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_CRUD.DataAcces;
using Proyecto_CRUD.Models;

namespace Proyecto_CRUD.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public List<ContactoModel> Contactos { get; set; } = new();

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Contactos = _context.Contactos.ToList();
    }
}
