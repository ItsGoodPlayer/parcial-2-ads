using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class VentaDAL : BaseDAO<VentaBE>
    {
        public VentaDAL() : base("Ventas")
        {
        }

        public bool GuardarVentaCompleta(VentaBE venta)
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

        public List<VentaBE> ObtenerVentasPorRangoFecha(DateTime fechaInicio, DateTime fechaFin)
        {
        }

        protected override VentaBE MapearEntidad(DataRow row)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosInsertar(VentaBE entidad)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosActualizar(VentaBE entidad)
        {
        }

        protected override string ObtenerQueryInsertar()
        {
        }

        protected override string ObtenerQueryActualizar()
        {
        }

        private bool GuardarDetalles(List<DetalleVentaBE> detalles, int ventaId)
        {
        }

        private List<DetalleVentaBE> CargarDetallesVenta(int ventaId)
        {
        }

        private DetalleVentaBE MapearDetalleVenta(DataRow row)
        {
        }
    }
}