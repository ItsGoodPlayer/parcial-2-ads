using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class LaboratorioDAL : BaseDAO<LaboratorioBE>
    {
        public LaboratorioDAL() : base("Laboratorios")
        {
        }

        public List<LaboratorioBE> ObtenerActivos()
        {
        }

        public LaboratorioBE ObtenerPorNombre(string nombre)
        {
        }

        public List<LaboratorioBE> BuscarPorPais(string pais)
        {
        }

        public bool ValidarLaboratorio(int laboratorioId)
        {
        }

        protected override LaboratorioBE MapearEntidad(DataRow row)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosInsertar(LaboratorioBE entidad)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosActualizar(LaboratorioBE entidad)
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

        private string ObtenerQueryPorNombre()
        {
        }
    }
}