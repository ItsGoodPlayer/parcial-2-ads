using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class CategoriaDAL : BaseDAO<CategoriaBE>
    {
        public CategoriaDAL() : base("Categorias")
        {
        }

        public List<CategoriaBE> ObtenerActivas()
        {
        }

        public List<CategoriaBE> ObtenerPorTipoReceta(bool requiereReceta)
        {
        }

        public CategoriaBE ObtenerPorNombre(string nombre)
        {
        }

        public bool ValidarCategoria(int categoriaId)
        {
        }

        protected override CategoriaBE MapearEntidad(DataRow row)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosInsertar(CategoriaBE entidad)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosActualizar(CategoriaBE entidad)
        {
        }

        protected override string ObtenerQueryInsertar()
        {
        }

        protected override string ObtenerQueryActualizar()
        {
        }

        private string ObtenerQueryActivas()
        {
        }

        private string ObtenerQueryPorTipoReceta()
        {
        }

        private string ObtenerQueryPorNombre()
        {
        }
    }
}