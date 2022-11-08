using System.ComponentModel.DataAnnotations;

namespace GuiaTuristicaLSIA.API.Models
{
    public class Buzon
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset FechaRegistro { get; set; }
        public string Comentario { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int LugarId { get; set; }
        public Lugar? Lugar { get; set; }
        [Required]
        public string UsuarioId { get; set; }
        [Required]
        [Range(0.0,5.0)]
        public float Estrellas { get; set; }
    }
}
