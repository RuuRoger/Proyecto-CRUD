using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto_CRUD.Models;

public class ContactoModel
{
    public int IdContacto { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    [Required]
        public string Telefono { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;
}