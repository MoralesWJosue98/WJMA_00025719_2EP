namespace Preparcial.Modelo
{
    public class Usuario
    {
        //Convertir los que no son string
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public bool Admin { get; set; }

        public Usuario(int idUsuario, string nombreUsuario, string contrasenia, bool admin)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasenia;
            Admin = admin;
        }
    }
}
