using System.ComponentModel.DataAnnotations;

namespace WebApiTallerRefuerzoDos.DTOs
{
    public class GruposResponse
    {
     
        public int Id { get; set; }
      
        public string Nombre { get; set; }
    } 
    public class GruposRequest
    {
        
        public int Id { get; set; }
       
        public string Nombre { get; set; }
    }
}
