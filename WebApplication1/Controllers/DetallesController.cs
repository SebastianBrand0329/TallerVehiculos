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
    
    [ApiController]
    [Route("api/detalles")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class DetallesController: Controller 
    {
        private readonly ILogger<MarcaVehiculosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public DetallesController(ILogger<MarcaVehiculosController> logger, ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<DetalleDTO>>> Get()
        {
            var detalle = await context.Detalles.ToListAsync();

            if (detalle == null)
            {
                return NotFound();
            }

            return mapper.Map<List<DetalleDTO>>(detalle);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<DetalleDTO>> Get(int id)
        {
            var detalle = await context.MarcaVehiculos.FirstOrDefaultAsync(x => x.Id == id);

            if (detalle == null)
            {
                return NotFound();
            }
            return mapper.Map<DetalleDTO>(detalle);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] DetalleCreacionDTO detalleCreacionDTO)
        {
            var detalle = mapper.Map<Detalle>(detalleCreacionDTO);
            context.Add(detalle);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("id:int")]
        public async Task<ActionResult> Put(int id, Detalle detalle)
        {
            if (detalle.Id != id)
            {
                return NotFound();
            }

            var existe = await context.Detalles.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return BadRequest("La marca no existe");
            }

            context.Update(detalle);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var detalle = await context.Detalles.FirstOrDefaultAsync(x => x.Id == id);

            if (detalle == null)
            {
                return NotFound();
            }

            context.Remove(detalle);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
