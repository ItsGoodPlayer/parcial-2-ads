using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public abstract class BaseDAO<T> : IDAO<T>
    {
        protected AccesoDAL accesoDAL;
        protected string tableName;

        protected BaseDAO(string tableName)
        {
        }

        public virtual bool Insertar(T entidad)
        {
        }

        public virtual bool Actualizar(T entidad)
        {
        }

        public virtual bool Eliminar(int id)
        {
        }

        public virtual T ObtenerPorId(int id)
        {
        }

        public virtual List<T> ObtenerTodos()
        {
        }

        public virtual bool Existe(int id)
        {
        }

        protected abstract T MapearEntidad(DataRow row);

        protected abstract List<SqlParameter> ObtenerParametrosInsertar(T entidad);

        protected abstract List<SqlParameter> ObtenerParametrosActualizar(T entidad);

        protected virtual string ObtenerQueryInsertar()
        {
        }

        protected virtual string ObtenerQueryActualizar()
        {
        }

        protected virtual string ObtenerQueryEliminar()
        {
        }

        protected virtual string ObtenerQueryPorId()
        {
        }

        protected virtual string ObtenerQueryTodos()
        {
        }

        protected virtual string ObtenerQueryExiste()
        {
        }

        private void InicializarAcceso()
        {
        }

        protected void IniciarTransaccion()
        {
        }

        protected void ConfirmarTransaccion()
        {
        }

        protected void DeshacerTransaccion()
        {
        }
    }
}