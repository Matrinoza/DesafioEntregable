using Microsoft.AspNetCore.Mvc;
using SistemaGestionNegocios;
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
            var productos = ProductoNegocios.ObtenerTodosLosProductos();
            return productos.Count == 0 ? NotFound("No se encontraron productos.") : Ok(productos);
        }

        [HttpPost("CrearProducto")]
        public ActionResult CrearProducto([FromBody] Producto nuevoProducto)
        {
            ProductoNegocios.CrearProducto(nuevoProducto);
            return CreatedAtAction(nameof(CrearProducto), new { id = nuevoProducto.Id }, nuevoProducto);
        }

        [HttpPut("ModificarProducto/{id}")]
        public ActionResult ModificarProducto(int id, [FromBody] Producto productoModificado)
        {
            var exito = ProductoNegocios.ModificarProducto(id, productoModificado);
            return exito ? NoContent() : NotFound("Producto no encontrado.");
        }

        [HttpDelete("EliminarProducto/{id}")]
        public ActionResult EliminarProducto(int id)
        {
            var exito = ProductoNegocios.EliminarProducto(id);
            return exito ? NoContent() : NotFound("Producto no encontrado.");
        }
    }
}
