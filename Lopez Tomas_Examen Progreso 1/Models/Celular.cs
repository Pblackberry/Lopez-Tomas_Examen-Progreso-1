using System.ComponentModel.DataAnnotations;

namespace Lopez_Tomas_Examen_Progreso_1.Models
{
    public class Celular
    {
        [Key]
        public int IDcelular { get; set; }
        [Required]
        public string modelo { get; set; }
        [Required]
       // [MaxLength(10)]
       // [MinLength(10)]
        public int numero { get; set; }
       // [MaxLength(4)]
       // [MinLength(4)]
        public int año {  get; set; }   
        public float precio { get; set; }   
    }
}
