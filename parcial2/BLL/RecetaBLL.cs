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

        public decimal ObtenerDescuentoObraSocial(RecetaBE receta)
        {
        }
    }
}