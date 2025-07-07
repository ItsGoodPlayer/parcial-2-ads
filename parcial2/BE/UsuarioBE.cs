using System;

namespace BE
{
    public abstract class UsuarioBE
    {
        private int id;
        private string dni;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string direccion;
        private DateTime fechaRegistro;
        private bool esActivo;

        protected UsuarioBE()
        {
        }

        protected UsuarioBE(string dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaRegistro = DateTime.Now;
            this.esActivo = true;
        }

        public abstract string ObtenerTipoUsuario();

        public virtual string NombreCompleto()
        {
            return $"{nombre} {apellido}";
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetDNI()
        {
            return dni;
        }

        public void SetDNI(string dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string GetDireccion()
        {
            return direccion;
        }

        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public DateTime GetFechaRegistro()
        {
            return fechaRegistro;
        }

        public void SetFechaRegistro(DateTime fechaRegistro)
        {
            this.fechaRegistro = fechaRegistro;
        }

        public bool GetEsActivo()
        {
            return esActivo;
        }

        public void SetEsActivo(bool esActivo)
        {
            this.esActivo = esActivo;
        }
    }
}