using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public class VentaDAL
    {
        private string connectionString;

        public VentaDAL()
        {
        }

        public VentaDAL(string connectionString)
        {
        }

        public bool GuardarVenta(VentaBE venta)
        {
        }

        public VentaBE ObtenerPorId(int id)
        {
        }

        public List<VentaBE> ObtenerVentasPorFecha(DateTime fecha)
        {
        }

        public bool GuardarDetalleVenta(DetalleVentaBE detalle)
        {
        }

        public List<DetalleVentaBE> ObtenerDetallesPorVenta(int ventaId)
        {
        }

        private int ObtenerProximoId()
        {
        }

        protected void IniciarTransaccion()
        {
        }

        protected void ConfirmarTransaccion()
        {
        }

        protected void RollbackTransaccion()
        {
        }
    }
}