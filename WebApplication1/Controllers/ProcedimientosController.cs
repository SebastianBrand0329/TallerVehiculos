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
    [Route("api/procedimientos")]
    public class ProcedimientosController : Controller
    {
        private readonly ILogger<ProcedimientosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProcedimientosController(ILogger<ProcedimientosController> logger, ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProcedimientoDTO>>> Get()
        {
            var procedimiento = await context.Procedimientos.ToListAsync();

            if (procedimiento == null)
            {
                return NotFound();
            }

            return mapper.Map<List<ProcedimientoDTO>>(procedimiento);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<ProcedimientoDTO>> Get(int id)
        {
            var procedimiento = await context.Procedimientos.FirstOrDefaultAsync(x => x.Id == id);

            if (procedimiento == null)
            {
                return NotFound();
            }

            return mapper.Map<ProcedimientoDTO>(procedimiento);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] ProcedimientoCreacionDTO procedimientoCreacionDTO)
        {
            var procedimiento = mapper.Map<Procedimiento>(procedimientoCreacionDTO);
            context.Add(procedimiento);
            await context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut("id:int")]
        public async Task<ActionResult> Put(int id, Procedimiento procedimiento)
        {
            if(procedimiento.Id != id)
            {
                return BadRequest("El procedimiento no existe");
            }

            var existe = await context.Procedimientos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Update(procedimiento);
            await context.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var procedimiento = await context.Procedimientos.FirstOrDefaultAsync(x => x.Id == id);

            if(procedimiento == null)
            {
                return NotFound();
            }

            context.Remove(procedimiento);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
