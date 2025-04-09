using System.ComponentModel.DataAnnotations;

namespace IngenieriaWeb1.Models
{
    public class Autos
    {
        [Key] // Indica que AutoId es la clave primaria
        public int AutoId { get; set; }

        [Required(ErrorMessage = "La placa es obligatoria")]
        [StringLength(10, ErrorMessage = "La placa no puede exceder los 10 caracteres")]
        public string? Placa { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria")]
        [StringLength(50, ErrorMessage = "La marca no puede exceder los 50 caracteres")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio")]
        [StringLength(50, ErrorMessage = "El modelo no puede exceder los 50 caracteres")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "El propietario es obligatorio")]
        [StringLength(50, ErrorMessage = "El propietario no puede exceder los 50 caracteres")]
        public string? Propietario { get; set; }

        [Range(1900, 2025, ErrorMessage = "El año debe estar entre 1900 y 2025")]
        public int Año { get; set; }
    }
}