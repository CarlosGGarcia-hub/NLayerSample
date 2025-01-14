using DAL;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace NLayersSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private EquipoService _equipoLogic;

        public EquipoController(AppDbContext context)
        {
            _equipoLogic = new EquipoService(context);
        }

        [HttpGet]
        [Route("ObtenerPosicion/{documento}")]
        public async Task<ActionResult> ObtenerPosicion(string documento)
        {
            return Ok(_equipoLogic.ObtenerEquipo(documento));
        } 

    }
}
