using System.ComponentModel.DataAnnotations;

namespace WebApiTallerRefuerzoDos.Model
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }

        public ICollection<Contacto> Contactos { get; set; }
    }
}
