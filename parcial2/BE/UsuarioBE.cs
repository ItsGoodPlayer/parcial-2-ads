using System;

namespace BE
{
    public abstract class UsuarioBE
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool EsActivo { get; set; }

        protected UsuarioBE()
        {
        }

        protected UsuarioBE(string dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaRegistro = DateTime.Now;
            EsActivo = true;
        }

        public abstract string ObtenerTipoUsuario();

        public virtual string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}