using System;

namespace BE
{
    public class ObraSocialBE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public bool EsActiva { get; set; }
        public string TipoCobertura { get; set; }

        public ObraSocialBE()
        {
        }

        public ObraSocialBE(string nombre, string codigo, decimal porcentajeDescuento)
        {
            Nombre = nombre;
            Codigo = codigo;
            PorcentajeDescuento = porcentajeDescuento;
            EsActiva = true;
        }
    }
}