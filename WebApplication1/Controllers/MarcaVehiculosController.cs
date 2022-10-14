using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TallerVehiculos.Data;
using TallerVehiculos.DTOS;
using TallerVehiculos.Entidades;

namespace TallerVehiculos.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "Admin")]
    [ApiController]
    [Route("api/marcavehiculos")]
    public class MarcaVehiculosController : Controller
    {
        private readonly ILogger<MarcaVehiculosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MarcaVehiculosController(ILogger<MarcaVehiculosController> logger, ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MarcaVehiculoDTO>>> Get()
        {
            var marca = await context.MarcaVehiculos.ToListAsync();

            if (marca == null)
            {
                return NotFound();
            }

            return mapper.Map<List<MarcaVehiculoDTO>>(marca);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<MarcaVehiculoDTO>> Get(int id)
        {
            var marca = await context.MarcaVehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if(marca == null)
            {
                return NotFound();
            }
            return mapper.Map<MarcaVehiculoDTO>(marca);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm]MarcaVehiculoCreacionDTO marcaVehiculoCreacionDTO)
        {
            var marca = mapper.Map<MarcaVehiculo>(marcaVehiculoCreacionDTO);
            context.Add(marca);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("id:int")]
        public async Task<ActionResult> Put(int id, MarcaVehiculo marcaVehiculo)
        {
            if(marcaVehiculo.Id != id)
            {
                return NotFound();
            }

            var existe = await context.MarcaVehiculos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return BadRequest("La marca no existe");
            }

            context.Update(marcaVehiculo);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var marca = await context.MarcaVehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if(marca == null)
            {
                return NotFound();
            }

            context.Remove(marca);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
