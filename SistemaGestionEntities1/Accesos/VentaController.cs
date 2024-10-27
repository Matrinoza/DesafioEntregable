using Microsoft.AspNetCore.Mvc;
using SistemaGestionNegocios;
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
            var ventas = VentaNegocios.ObtenerTodasLasVentas();
            return ventas.Count == 0 ? NotFound("No se encontraron ventas.") : Ok(ventas);
        }

        [HttpPost("CargarVenta")]
        public ActionResult CargarVenta([FromBody] Venta nuevaVenta)
        {
            VentaNegocios.CargarVenta(nuevaVenta);
            return CreatedAtAction(nameof(CargarVenta), new { id = nuevaVenta.Id }, nuevaVenta);
        }

        [HttpDelete("EliminarVenta/{id}")]
        public ActionResult EliminarVenta(int id)
        {
            var exito = VentaNegocios.EliminarVenta(id);
            return exito ? NoContent() : NotFound("Venta no encontrada.");
        }
    }
}
