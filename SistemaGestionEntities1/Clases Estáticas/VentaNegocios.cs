public static class VentaNegocio
{
    public static List<Venta> ObtenerTodasLasVentas()
    {
        return VentaData.ObtenerVentas();
    }
    public static void AgregarVenta(Venta venta)
    {
        VentaData.AgregarVenta(venta);
    }
    public static void ActualizarVenta(Venta venta)
    {
        VentaData.ActualizarVenta(venta);
    }
    public static void EliminarVenta(int id)
    {
        VentaData.EliminarVenta(id);
    }
}
