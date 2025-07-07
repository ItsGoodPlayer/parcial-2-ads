using System;

namespace BE
{
    public class CategoriaBE
    {
        private int id;
        private string nombre;
        private string descripcion;
        private bool requiereRecetaMedica;
        private int edadMinimaVenta;
        private bool esActiva;

        public CategoriaBE()
        {
        }

        public CategoriaBE(string nombre, bool requiereRecetaMedica)
        {
            this.nombre = nombre;
            this.requiereRecetaMedica = requiereRecetaMedica;
            this.esActiva = true;
            this.edadMinimaVenta = 0;
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

        public string GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public bool GetRequiereRecetaMedica()
        {
            return requiereRecetaMedica;
        }

        public void SetRequiereRecetaMedica(bool requiereRecetaMedica)
        {
            this.requiereRecetaMedica = requiereRecetaMedica;
        }

        public int GetEdadMinimaVenta()
        {
            return edadMinimaVenta;
        }

        public void SetEdadMinimaVenta(int edadMinimaVenta)
        {
            this.edadMinimaVenta = edadMinimaVenta;
        }

        public bool GetEsActiva()
        {
            return esActiva;
        }

        public void SetEsActiva(bool esActiva)
        {
            this.esActiva = esActiva;
        }
    }
}