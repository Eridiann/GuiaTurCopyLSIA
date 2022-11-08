using System.ComponentModel.DataAnnotations;

namespace GuiaTuristicaLSIA.API.Models
{
    public class Anuncio
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset FechaRegistro { get; set; }
        [Required]
        [MinLength(10), MaxLength(20)]
        public string Titulo { get; set; }
        [Required]
        [MinLength(20), MaxLength(50)]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaTermino { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}
