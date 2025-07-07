using System;

namespace BE
{
    public class MetodoPagoBE
    {
        private int id;
        private string nombre;
        private string tipo;
        private bool esActivo;
        private decimal comisionPorcentaje;
        private bool requiereAutorizacion;

        public MetodoPagoBE()
        {
        }

        public MetodoPagoBE(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
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

        public string GetTipo()
        {
            return tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public bool GetEsActivo()
        {
            return esActivo;
        }

        public void SetEsActivo(bool esActivo)
        {
            this.esActivo = esActivo;
        }

        public decimal GetComisionPorcentaje()
        {
            return comisionPorcentaje;
        }

        public void SetComisionPorcentaje(decimal comisionPorcentaje)
        {
            this.comisionPorcentaje = comisionPorcentaje;
        }

        public bool GetRequiereAutorizacion()
        {
            return requiereAutorizacion;
        }

        public void SetRequiereAutorizacion(bool requiereAutorizacion)
        {
            this.requiereAutorizacion = requiereAutorizacion;
        }
    }
}