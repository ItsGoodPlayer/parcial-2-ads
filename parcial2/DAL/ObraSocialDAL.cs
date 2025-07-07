using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class ObraSocialDAL : BaseDAO<ObraSocialBE>
    {
        public ObraSocialDAL() : base("ObrasSociales")
        {
        }

        public ObraSocialBE ObtenerPorCodigo(string codigo)
        {
        }

        public bool ExisteObraSocial(string codigo)
        {
        }

        public decimal ObtenerPorcentajeDescuento(int obraSocialId)
        {
        }

        public List<ObraSocialBE> ObtenerActivas()
        {
        }

        public List<ObraSocialBE> BuscarPorNombre(string nombre)
        {
        }

        protected override ObraSocialBE MapearEntidad(DataRow row)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosInsertar(ObraSocialBE entidad)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosActualizar(ObraSocialBE entidad)
        {
        }

        protected override string ObtenerQueryInsertar()
        {
        }

        protected override string ObtenerQueryActualizar()
        {
        }

        private bool ValidarCodigoObraSocial(string codigo)
        {
        }

        protected void CacheearObrasSociales()
        {
        }

        private string ObtenerQueryPorCodigo()
        {
        }
    }
}