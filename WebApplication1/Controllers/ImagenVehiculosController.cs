using TallerVehiculos.Servicios;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallerVehiculos.Data;
using TallerVehiculos.DTOS;
using TallerVehiculos.Entidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace TallerVehiculos.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    [ApiController]
    [Route("api/imagenvehiculos")]
    public class ImagenVehiculosController:Controller
    {
        private readonly ILogger<ImagenVehiculosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "Files";

        public ImagenVehiculosController(ILogger<ImagenVehiculosController> logger, ApplicationDbContext context, IMapper mapper,
            IAlmacenadorArchivos almacenadorArchivos)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
            this.almacenadorArchivos = almacenadorArchivos;
        }

        [HttpGet]
        public async Task<ActionResult<List<ImagenVehiculoDTO>>> Get()
        {
            var imagen = await context.ImagenVehiculos.ToListAsync();
            return mapper.Map<List<ImagenVehiculoDTO>>(imagen);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<ImagenVehiculoDTO>> Get(int id)
        {
            var imagen = await context.ImagenVehiculos.FirstOrDefaultAsync(x => x.Id == id);
            if (imagen == null)
            {
                return NotFound();
            }

            return mapper.Map<ImagenVehiculoDTO>(imagen);

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] ImagenVehiculoCreacionDTO imagenVehiculoCreacionDTO)
        {
            var imagen = mapper.Map<ImagenVehiculo>(imagenVehiculoCreacionDTO);

            if (imagenVehiculoCreacionDTO.Foto != null)
            {
                imagen.Foto = await almacenadorArchivos.GuardarArchivo(contenedor, imagenVehiculoCreacionDTO.Foto);
            }

            context.Add(imagen);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("id:int")]
        public async Task<ActionResult> Put(ImagenVehiculo imagenVehiculo, int id)
        {
            if (imagenVehiculo.Id != id)
            {
                return BadRequest("La imagen no existe");
            }

            var existe = await context.ImagenVehiculos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Update(imagenVehiculo);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var imagen = await context.ImagenVehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if (imagen == null)
            {
                return NotFound();
            }

            context.Remove(imagen);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
