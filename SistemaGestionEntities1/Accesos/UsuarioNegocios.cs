public static class UsuarioNegocios
{
    public static Usuario IniciarSesion(string nombreUsuario, string contrasenia) => UsuarioData.IniciarSesion(nombreUsuario, contrasenia);
    public static void CrearUsuario(Usuario usuario) => UsuarioData.CrearUsuario(usuario);
    public static bool ModificarUsuario(int id, Usuario usuario) => UsuarioData.ModificarUsuario(id, usuario);
    public static bool EliminarUsuario(int id) => UsuarioData.EliminarUsuario(id);
}
