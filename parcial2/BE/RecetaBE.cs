using System;

namespace BE
{
    public class RecetaBE
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroReceta { get; set; }
        public string Medico { get; set; }
        public string Paciente { get; set; }
        public ObraSocialBE ObraSocial { get; set; }
        public bool EsVigente { get; set; }

        public RecetaBE()
        {
        }

        public RecetaBE(DateTime fecha, string numeroReceta, string medico)
        {
        }

        public bool ValidarVigencia()
        {
        }

        public void AsignarObraSocial(ObraSocialBE obraSocial)
        {
        }

        private bool VerificarFechaVencimiento()
        {
        }

        protected bool ValidarDatosMinimos()
        {
        }

        public decimal ObtenerPorcentajeDescuento()
        {
        }
    }
}