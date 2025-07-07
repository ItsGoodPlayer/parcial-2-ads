using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public class VentaDAL : BaseDAO<VentaBE>
    {
        public VentaDAL()
        {
        }

        public override List<VentaBE> Listar()
        {
        }

        public bool GuardarVentaCompleta(VentaBE venta)
        {
        }

        public List<VentaBE> ObtenerVentasPorFecha(DateTime fecha)
        {
        }
    }
}