using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallerVehiculos.Data;
using TallerVehiculos.DTOS;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.Controllers
{
    [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    [ApiController]
    [Route("api/vehiculos")]
    public class VehiculosController: Controller
    {
        private readonly ILogger<VehiculosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public VehiculosController(ILogger<VehiculosController> logger, ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<VehiculoDTO>>> Get()
        {
            var vehiculo = await context.Vehiculos.ToListAsync();
            if(vehiculo == null)
            {
                return NoContent();
            }
            return mapper.Map<List<VehiculoDTO>>(vehiculo);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<VehiculoDTO>> Get(int id)
        {
            var vehiculo = await context.Vehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if(vehiculo == null)
            {
                return NotFound();
            }

            return mapper.Map<VehiculoDTO>(vehiculo);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm]VehiculoCreacionDTO vehiculoCreacionDTO)
        {
            var vehiculo = mapper.Map<Vehiculo>(vehiculoCreacionDTO);
            context.Add(vehiculo);
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut("id:int")]
        public async Task<ActionResult> Put(int id, Vehiculo vehiculo)
        {
            if(vehiculo.Id != id)
            {
                return BadRequest("El Vehiculo no existe");
            }

            var existe = await context.Vehiculos.AnyAsync(x => x.Id == id);

            if(!existe)
            {
                return NotFound();
            }
            context.Update(vehiculo);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var vehiculo = await context.Vehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if(vehiculo == null)
            {
                return NotFound();
            }
            context.Remove(vehiculo);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
