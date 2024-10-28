using System.ComponentModel.DataAnnotations;

namespace Lopez_Tomas_Examen_Progreso_1.Models
{
    public class Celular
    {
        [Key]
        public int IDcelular { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string modelo { get; set; }
        [Required]
      
        public int numero { get; set; }
        
        public int año {  get; set; }   
        public float precio { get; set; }   
    }
}
