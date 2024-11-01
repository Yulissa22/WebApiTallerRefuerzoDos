using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApiTallerRefuerzoDos.Model;

namespace WebApiTallerRefuerzoDos.DTOs
{
    public class ContactosResponse
    {
        
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public string Telefono { get; set; }

        public int? GrupoId { get; set; }
    }

    public class ContactosRequest    
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public int? GrupoId { get; set; }
    }

}
