using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class RecetaBLL : ValidadorBaseBLL
    {
        private ObraSocialDAL obraSocialDAL;

        public RecetaBLL()
        {
        }

        public RecetaBLL(ObraSocialDAL obraSocialDAL)
        {
        }

        public override bool Validar(object objeto)
        {
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

        protected override bool ValidarDatosObligatorios(object objeto)
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