using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class MetodoPagoDAL : BaseDAO<MetodoPagoBE>
    {
        public MetodoPagoDAL() : base("MetodosPago")
        {
        }

        public List<MetodoPagoBE> ObtenerActivos()
        {
        }

        public MetodoPagoBE ObtenerPorTipo(string tipo)
        {
        }

        public bool ValidarMetodoPago(int metodoPagoId)
        {
        }

        protected override MetodoPagoBE MapearEntidad(DataRow row)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosInsertar(MetodoPagoBE entidad)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosActualizar(MetodoPagoBE entidad)
        {
        }

        protected override string ObtenerQueryInsertar()
        {
        }

        protected override string ObtenerQueryActualizar()
        {
        }

        private string ObtenerQueryActivos()
        {
        }
    }
}