using System;

namespace BE
{
    public class MetodoPagoBE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public bool EsActivo { get; set; }
        public decimal ComisionPorcentaje { get; set; }
        public bool RequiereAutorizacion { get; set; }

        public MetodoPagoBE()
        {
        }

        public MetodoPagoBE(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
            EsActivo = true;
        }
    }
}