using System;
using System.Collections.Generic;
using BE;

namespace BLL
{
    public abstract class ValidadorBaseBLL
    {
        protected List<string> errores;

        protected ValidadorBaseBLL()
        {
        }

        public abstract bool Validar(object objeto);

        public List<string> ObtenerErrores()
        {
        }

        public bool TieneErrores()
        {
        }

        protected void AgregarError(string error)
        {
        }

        protected void LimpiarErrores()
        {
        }

        protected abstract bool ValidarDatosObligatorios(object objeto);

        protected virtual bool ValidarFormato(string campo, string valor)
        {
        }

        private bool ValidarCampoVacio(string valor)
        {
        }
    }
}