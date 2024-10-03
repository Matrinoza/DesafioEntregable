public static class UsuarioNeogcio
{
    public static List<Usuario> ObtenerTodosLosUsuarios()
    {
        return UsuarioData.ObtenerUsuarios();
    }
    public static void AgregarUsuario(Usuario usuario)
    {
        UsuarioData.AgregarUsuario(usuario);
    }
    public static void ActualizarUsuario(Usuario usuario)
    {
        UsuarioData.ActualizarUsuario(usuario);
    }
    public static void EliminarUsuario(int id)
    {
        UsuarioData.EliminarUsuario(id);
    }
}
