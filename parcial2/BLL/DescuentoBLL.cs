using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class DescuentoBLL
    {
        private ObraSocialDAL obraSocialDAL;

        public DescuentoBLL()
        {
            obraSocialDAL = new ObraSocialDAL();
        }

        public DescuentoBLL(ObraSocialDAL obraSocialDAL)
        {
            this.obraSocialDAL = obraSocialDAL;
        }

        public decimal CalcularDescuentoObraSocial(VentaBE venta)
        {
        }

        public decimal CalcularDescuentoTotal(VentaBE venta)
        {
        }

        public bool EsAplicableDescuento(VentaBE venta, ObraSocialBE obraSocial)
        {
        }
    }
}