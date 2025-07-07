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
            Fecha = fecha;
            NumeroReceta = numeroReceta;
            Medico = medico;
        }
    }
}