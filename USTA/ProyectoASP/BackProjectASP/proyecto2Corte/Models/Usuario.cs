using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto2Corte.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }

        [EmailAddress]
        [Display(Name = "Correo Electrónico")]
        public string? CorreoElectronico { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string? Contraseña { get; set; }

        [Required]
        [Display(Name = "Rol")]
        public string? Rol { get; set; }

        // Relaciones
        public ICollection<Respuesta>? Respuestas { get; set; }
    }
}
