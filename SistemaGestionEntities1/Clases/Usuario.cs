public class Venta
{
    public int Id { get; set; }
    public string Comentario { get; set; }
    public int Usuario { get; set; }
    public List<ProductoVendido> ProductosVendidos { get; set; } = new List<ProductoVendido>();
}
