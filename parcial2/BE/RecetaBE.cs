using System;

namespace BE
{
    public class RecetaBE
    {
        private int id;
        private DateTime fecha;
        private string numeroReceta;
        private string medico;
        private ClienteBE paciente;
        private ObraSocialBE obraSocial;
        private bool esVigente;

        public RecetaBE()
        {
        }

        public RecetaBE(DateTime fecha, string numeroReceta, string medico, ClienteBE paciente)
        {
            this.fecha = fecha;
            this.numeroReceta = numeroReceta;
            this.medico = medico;
            this.paciente = paciente;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }

        public void SetFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public string GetNumeroReceta()
        {
            return numeroReceta;
        }

        public void SetNumeroReceta(string numeroReceta)
        {
            this.numeroReceta = numeroReceta;
        }

        public string GetMedico()
        {
            return medico;
        }

        public void SetMedico(string medico)
        {
            this.medico = medico;
        }

        public ClienteBE GetPaciente()
        {
            return paciente;
        }

        public void SetPaciente(ClienteBE paciente)
        {
            this.paciente = paciente;
        }

        public ObraSocialBE GetObraSocial()
        {
            return obraSocial;
        }

        public void SetObraSocial(ObraSocialBE obraSocial)
        {
            this.obraSocial = obraSocial;
        }

        public bool GetEsVigente()
        {
            return esVigente;
        }

        public void SetEsVigente(bool esVigente)
        {
            this.esVigente = esVigente;
        }
    }
}