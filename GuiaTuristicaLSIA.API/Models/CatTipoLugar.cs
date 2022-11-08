using System.ComponentModel.DataAnnotations;

namespace GuiaTuristicaLSIA.API.Models
{
    public class CatTipoLugar
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5,ErrorMessage ="Captura completo el tipo de lugar")]
        public string TipoLugar { get; set; }
        ICollection<Lugar> Lugares { get; set; }
    }
}
