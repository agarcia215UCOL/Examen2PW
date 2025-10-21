
using System.ComponentModel.DataAnnotations;
namespace Examen2PW.Components.Models;

public class Producto
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "El inventario debe ser un valor entero mayor a 0")]
    public string? Inventario { get; set; }
    [Required(ErrorMessage = "Debe seleccionar un departamento")]
    public string? Departamento { get; set; }
}

