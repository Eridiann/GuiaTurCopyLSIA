using System.ComponentModel.DataAnnotations;

namespace GuiaTuristicaLSIA.API.Models
{
    public class Lugar
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset FechaRegistro { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [MinLength(50,ErrorMessage ="Sé más específico")]
        public string Descripcion { get; set; }
        [Required]
        public string Latitud { get; set; }
        [Required]
        public string Longitud { get; set; }
        [Required]
        public bool Gratuito { get; set; }
        [Required]
        public bool Activo { get; set; }
        public string? Horario { get; set; } //El ? es para lo no requerido
        public string? URLOficial { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int TipoLugarId { get; set; }
        public CatTipoLugar? TipoLugar { get; set; }
        [Required]
        public float EstrellasPromedio { get; set; }

        ICollection<Fotografias> Fotografias { get; set; }
        ICollection<Buzon> Buzones { get; set; }

    }
}
