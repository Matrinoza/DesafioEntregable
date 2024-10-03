public class Venta
{
    public int Id { get; set; }
public string Comentario { get; set; }
public int IdUsuario { get; set; }
public List< ProductoVendido > ProductosVendidos { get; set; } = new List<ProductoVendido>();
}
