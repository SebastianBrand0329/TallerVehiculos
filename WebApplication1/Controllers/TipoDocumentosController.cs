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
    [Route("api/tipodocumentos")]
    public class TipoDocumentosController: Controller
    {
        private readonly ILogger<TipoDocumentosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public TipoDocumentosController(ILogger<TipoDocumentosController> logger, ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TipoDocumentoDTO>>> Get()
        {
            var tipo = await context.TipoDocumentos.ToListAsync();

            if(tipo == null)
            {
                return NotFound();
            }

            return mapper.Map<List<TipoDocumentoDTO>>(tipo);    
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<TipoDocumentoDTO>> Get(int id)
        {
            var tipo = await context.TipoDocumentos.FirstOrDefaultAsync(x => x.Id == id);

            if(tipo == null)
            {
                return NotFound();
            }

            return mapper.Map<TipoDocumentoDTO>(tipo);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm]TipoVehiculoCreacionDTO tipoVehiculoCreacionDTO)
        {
            var tipo = mapper.Map<TipoDocumento>(tipoVehiculoCreacionDTO);
            context.Add(tipo);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("id:int")]
        public async Task<ActionResult> Put(int id, TipoDocumento tipoDocumento)
        {
            if(tipoDocumento.Id != id)
            {
                return BadRequest("El tipo documento no existe");
            }

            var existe = await context.TipoDocumentos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Update(tipoDocumento);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var tipo = await context.TipoDocumentos.FirstOrDefaultAsync(x => x.Id == id);

            if(tipo == null)
            {
                return NotFound();
            }

            context.Remove(tipo);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
