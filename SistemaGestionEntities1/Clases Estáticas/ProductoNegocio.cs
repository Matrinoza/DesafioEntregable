public static class ProductoVendidoNegocios
{
    public static List<ProductoVendido> ObtenerTodosLosProductosVendidos()
    {
        return ProductoVendidoData.ObtenerProductosVendidos();
    }
    public static void AgregarProductoVendido(ProductoVendido productoVendido)
    {
        ProductoVendidoData.AgregarProductoVendido(productoVendido);
    }
    public static void ActualizarProductoVendido(ProductoVendido productoVendido)
    {
        ProductoVendidoData.ActualizarProductoVendido(productoVendido);
    }
    public static void EliminarProductoVendido(int id)
    {
        ProductoVendidoData.EliminarProductoVendido(id);
    }
}
