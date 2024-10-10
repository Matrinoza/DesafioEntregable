using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : ControllerBase
    {
        [HttpGet("TraerVentas")]
        public ActionResult<List<Venta>> ObtenerVentas()
        {
            var ventas = VentaNegocio.ObtenerTodasLasVentas();
            if (ventas == null || ventas.Count == 0)
                return NotFound("No se encontraron ventas.");
            return Ok(ventas);
        }
    }
}