using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public abstract class BaseDAO<T> : IDAO<T>
    {
        protected AccesoDAL accesoDAL;

        protected BaseDAO()
        {
            accesoDAL = new AccesoDAL();
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

        public abstract List<T> Listar();

        public virtual bool Existe(int id)
        {
        }
    }
}