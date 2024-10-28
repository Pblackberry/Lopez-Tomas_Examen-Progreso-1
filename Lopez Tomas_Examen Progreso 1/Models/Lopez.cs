using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lopez_Tomas_Examen_Progreso_1.Models
{
    public class Lopez
    {
        [Key]
        public int IDlopez { get; set; }
        [MaxLength(100)]
        [Required]
        [MinLength(1)]
        public string nombre { get; set; }
        public Celular? celular { get; set; }
        [ForeignKey("Celular")]
        [Required]
        public int Ncelular { get; set; }
        public bool afiliado { get; set; }
        public DateTime fecha { get; set; }
        public float decFav { get; set; }


    }
}
