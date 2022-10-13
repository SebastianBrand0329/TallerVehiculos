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

            CreateMap<TipoVehiculoCreacionDTO, TipoVehiculo>();
            CreateMap<TipoVehiculo, TipoVehiculoDTO>().ReverseMap();

            CreateMap<MarcaVehiculoCreacionDTO, MarcaVehiculo>();
            CreateMap<MarcaVehiculo, MarcaVehiculoDTO>().ReverseMap();

            CreateMap<ImagenVehiculoCreacionDTO, ImagenVehiculo>();
            CreateMap<ImagenVehiculo, ImagenVehiculoDTO>().ReverseMap();

            CreateMap<ProcedimientoCreacionDTO, Procedimiento>();
            CreateMap<Procedimiento, ProcedimientoDTO>().ReverseMap();
        }
    }
}
