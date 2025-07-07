using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class RecetaBLL
    {
        private ObraSocialDAL obraSocialDAL;

        public RecetaBLL()
        {
            obraSocialDAL = new ObraSocialDAL();
        }

        public RecetaBLL(ObraSocialDAL obraSocialDAL)
        {
            this.obraSocialDAL = obraSocialDAL;
        }

        public bool ValidarReceta(RecetaBE receta)
        {
        }

        public bool ValidarVigencia(RecetaBE receta)
        {
        }

        public bool ValidarObraSocial(RecetaBE receta)
        {
        }

        public decimal ObtenerDescuentoObraSocial(RecetaBE receta)
        {
        }

        public bool ValidarRecetaVigente(DateTime fechaReceta)
        {
        }

        public void AsignarObraSocial(RecetaBE receta, ObraSocialBE obraSocial)
        {
        }

        private bool ValidarDatosObligatorios(RecetaBE receta)
        {
        }

        private bool ValidarFechaReceta(DateTime fechaReceta)
        {
        }

        private bool ValidarNumeroReceta(string numeroReceta)
        {
        }

        protected bool ValidarMedico(string medico)
        {
        }

        protected bool ValidarPaciente(string paciente)
        {
        }

        private bool EsRecetaVigente(DateTime fechaReceta)
        {
        }
    }
}