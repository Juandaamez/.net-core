using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto2Corte.Models
{
    public class Peticion
    {
        [Key]
        public int IdPeticion { get; set; }

        [Required]
        [Display(Name = "Fecha de Peticion")]
        public DateTime FechaPeticion { get; set; }

        [StringLength(100, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }

        [StringLength(20, ErrorMessage = "El documento debe tener entre 8 y 20 caracteres.", MinimumLength = 8)]
        [Display(Name = "Documento")]
        public string? Documento { get; set; }

        [EmailAddress]
        [Display(Name = "Correo Electrónico")]
        public string? Correo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El asunto debe tener entre 3 y 100 caracteres.", MinimumLength = 3)]
        [Display(Name = "Asunto")]
        public string? Asunto { get; set; }

        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }

        // Relaciones
        public ICollection<Respuesta>? Respuestas { get; set; }
    }
}
