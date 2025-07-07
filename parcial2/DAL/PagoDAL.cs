using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class PagoDAL : BaseDAO<PagoBE>
    {
        public PagoDAL() : base("Pagos")
        {
        }

        public List<PagoBE> ObtenerPorVenta(int ventaId)
        {
        }

        public bool GuardarPago(PagoBE pago)
        {
        }

        public bool ActualizarEstadoPago(int pagoId, string estado)
        {
        }

        public List<PagoBE> ObtenerPorEstado(string estado)
        {
        }

        protected override PagoBE MapearEntidad(DataRow row)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosInsertar(PagoBE entidad)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosActualizar(PagoBE entidad)
        {
        }

        protected override string ObtenerQueryInsertar()
        {
        }

        protected override string ObtenerQueryActualizar()
        {
        }

        private string ObtenerQueryPorVenta()
        {
        }

        private string ObtenerQueryActualizarEstado()
        {
        }
    }
}