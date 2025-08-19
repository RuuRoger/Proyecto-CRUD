using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Proyecto_CRUD.Models;

[Table("CONTACTO")]
public class ContactoModel
{
    [Key]
    public int IdContacto { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    public string Telefono { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;
}