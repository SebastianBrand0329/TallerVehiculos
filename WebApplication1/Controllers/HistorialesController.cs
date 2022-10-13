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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    [ApiController]
    [Route("api/historiales")]
    public class HistorialesController: Controller
    {
        private readonly ILogger<HistorialesController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public HistorialesController(ILogger<HistorialesController> logger, ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<HistorialDTO>>> Get()
        {
            var historial = await context.Historiales.ToListAsync();
            return mapper.Map<List<HistorialDTO>>(historial);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<HistorialDTO>> Get(int id)
        {
            var historial = await context.Historiales.FirstOrDefaultAsync(x => x.Id == id);
            if (historial == null)
            {
                return NotFound();
            }

            return mapper.Map<HistorialDTO>(historial);

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] HistorialCreacionDTO historialCreacionDTO)
        {
            var historial = mapper.Map<Historial>(historialCreacionDTO);
            context.Add(historial);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("id:int")]
        public async Task<ActionResult> Put(Historial historial, int id)
        {
            if (historial.Id != id)
            {
                return BadRequest("El hotel no existe");
            }

            var existe = await context.Historiales.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NoContent();
            }

            context.Update(historial);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var historial = await context.Historiales.FirstOrDefaultAsync(x => x.Id == id);

            if (historial == null)
            {
                return NoContent();
            }

            context.Remove(historial);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
 }
