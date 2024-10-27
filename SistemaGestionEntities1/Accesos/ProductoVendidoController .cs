using Microsoft.AspNetCore.Mvc;
using SistemaGestionNegocios;
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
            return productosVendidos.Count == 0 ? NotFound("No se encontraron productos vendidos.") : Ok(productosVendidos);
        }
    }
}
