using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTallerRefuerzoDos.Model
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public string Telefono { get; set; }
        
        public int? GrupoId { get; set; }

        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }
    }
}
