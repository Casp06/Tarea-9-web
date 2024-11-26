using System.ComponentModel.DataAnnotations;
public class Usuario
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    public string NombreUsuario { get; set; } 

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
    public string Correo { get; set; } 

    [Required(ErrorMessage = "La clave es obligatoria.")]
    public string Clave { get; set; } 

}

public class Vivencia
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Titulo { get; set; }

    [Required]
    public string Descripcion { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    public string Imagen { get; set; }

    [Required]
    public int UsuarioId { get; set; }
}
