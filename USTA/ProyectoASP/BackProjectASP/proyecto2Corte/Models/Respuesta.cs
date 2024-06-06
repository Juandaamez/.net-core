using System;
using System.ComponentModel.DataAnnotations;

namespace proyecto2Corte.Models
{
    public class Respuesta
    {
        [Key]
        public int IdRespuesta { get; set; }

        [Display(Name = "Fecha de Respuesta")]
        public DateTime? FechaRespuesta { get; set; }

        [StringLength(500, ErrorMessage = "La respuesta debe tener un máximo de 500 caracteres.")]
        [Display(Name = "Texto de la Respuesta")]
        public string? RespuestaTexto { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }

        [Required]
        public int IdPeticion { get; set; }
        public Peticion Peticion { get; set; }
    }
}
