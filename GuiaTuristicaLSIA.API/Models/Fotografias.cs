using System.ComponentModel.DataAnnotations;

namespace GuiaTuristicaLSIA.API.Models
{
    public class Fotografias
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset FechaRegistro { get; set; }
        [Required]
        public string URI { get; set; }
        [Required]
        public bool Activa { get; set; }
        [Required]
        public int LugarId { get; set; }
        public Lugar? Lugar { get; set; }
    }
}
