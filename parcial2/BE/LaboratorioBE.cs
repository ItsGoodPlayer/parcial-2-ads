using System;

namespace BE
{
    public class LaboratorioBE
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        private string email;
        private string pais;
        private bool esActivo;

        public LaboratorioBE()
        {
        }

        public LaboratorioBE(string nombre, string pais)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.esActivo = true;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetDireccion()
        {
            return direccion;
        }

        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetPais()
        {
            return pais;
        }

        public void SetPais(string pais)
        {
            this.pais = pais;
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