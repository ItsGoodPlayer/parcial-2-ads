using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public class ObraSocialDAL
    {
        private string connectionString;

        public ObraSocialDAL()
        {
        }

        public ObraSocialDAL(string connectionString)
        {
        }

        public List<ObraSocialBE> ObtenerTodas()
        {
        }

        public ObraSocialBE ObtenerPorId(int id)
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

        private bool ValidarCodigoObraSocial(string codigo)
        {
        }

        protected void CacheearObrasSociales()
        {
        }
    }
}