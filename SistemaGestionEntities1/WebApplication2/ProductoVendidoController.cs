using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("TraerProductosVendidos")]
        public ActionResult<List<ProductoVendido>> ObtenerProductosVendidos()
        {
            var productosVendidos = ProductoVendidoNegocios.ObtenerTodosLosProductosVendidos();
            if (productosVendidos == null || productosVendidos.Count == 0)
                return NotFound("No se encontraron productos vendidos.");
            return Ok(productosVendidos);
        }
    }
}