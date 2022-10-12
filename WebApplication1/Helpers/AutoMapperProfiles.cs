using AutoMapper;
using TallerVehiculos.DTOS;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<VehiculoCreacionDTO, Vehiculo>();
            CreateMap<Vehiculo, VehiculoDTO>().ReverseMap();
        }
    }
}
