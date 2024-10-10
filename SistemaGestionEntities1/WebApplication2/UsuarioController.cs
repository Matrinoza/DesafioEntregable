using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        [HttpGet("TraerProductos")]
        public ActionResult<List<Producto>> ObtenerProductos()
        {
            var productos = ProductoVendidoNegocios.ObtenerTodosLosProductos();
            if (productos == null || productos.Count == 0)
                return NotFound("No se encontraron productos.");
            return Ok(productos);
        }
    }
}

