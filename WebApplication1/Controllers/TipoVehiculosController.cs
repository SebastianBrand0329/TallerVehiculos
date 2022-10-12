using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallerVehiculos.Data;
using TallerVehiculos.DTOS;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.Controllers
{
    [ApiController]
    [Route("api/tipovehiculos")]
    public class TipoVehiculosController: Controller
    {
        private readonly ILogger<TipoVehiculosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public TipoVehiculosController(ILogger<TipoVehiculosController> logger, ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TipoVehiculoDTO>>> Get()
        {
            var tipo = await context.TipoVehiculos.ToListAsync();
            
            if(tipo == null)
            {
                return NotFound();
            }

            return mapper.Map<List<TipoVehiculoDTO>>(tipo); 
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<TipoVehiculoDTO>> Get(int id)
        {
            var tipo = await context.TipoVehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if(tipo == null)
            {
                return NotFound();
            }

            return mapper.Map<TipoVehiculoDTO>(tipo);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm]TipoVehiculoCreacionDTO tipoVehiculoCreacionDTO)
        {
            var tipo = mapper.Map<TipoVehiculo>(tipoVehiculoCreacionDTO);
            context.Add(tipo);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("id:int")]
        public async Task<ActionResult> Put(int id, TipoVehiculo tipoVehiculo)
        {
            if(tipoVehiculo.Id != id)
            {
                return NotFound();
            }

            var existe = await context.TipoVehiculos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return BadRequest("El tipo de vehiculo no existe");
            }

            context.Update(tipoVehiculo);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var tipo = await context.TipoVehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if(tipo == null)
            {
                return NotFound();
            }

            context.Remove(tipo);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
