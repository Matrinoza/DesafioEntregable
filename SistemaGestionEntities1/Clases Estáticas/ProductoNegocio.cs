public static class ProductoNegocio
{
    public static List<Producto> ObtenerTodosLosProductos()
    {
        return ProductoData.ObtenerProductos();
    }
    public static void AgregarProducto(Producto producto)
    {
        ProductoData.AgregarProducto(producto);
    }
    public static void ActualizarProducto(Producto producto)
    {
        ProductoData.ActualizarProducto(producto);
    }
    public static void EliminarProducto(int id)
    {
        ProductoData.EliminarProducto(id);
    }
}
