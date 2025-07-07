using System;
using System.Collections.Generic;

namespace DAL
{
    public interface IDAO<T>
    {
        bool Insertar(T entidad);
        bool Actualizar(T entidad);
        bool Eliminar(int id);
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        bool Existe(int id);
    }
}