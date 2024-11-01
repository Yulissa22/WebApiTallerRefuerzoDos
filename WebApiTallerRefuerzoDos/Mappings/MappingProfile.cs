using AutoMapper;
using WebApiTallerRefuerzoDos.DTOs;
using WebApiTallerRefuerzoDos.Model;

namespace WebApiTallerRefuerzoDos.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //Modelo -> DTO
            CreateMap<Contacto, ContactosResponse>();
            CreateMap<Grupo, GruposResponse>();

            //DTO ->Modelo
            CreateMap<ContactosRequest, Contacto>();
            CreateMap<GruposRequest, Grupo>();
        }
    }
}
