using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class CategoriaBLL
    {
        private CategoriaDAL categoriaDAL;

        public CategoriaBLL()
        {
            categoriaDAL = new CategoriaDAL();
        }

        public CategoriaBLL(CategoriaDAL categoriaDAL)
        {
            this.categoriaDAL = categoriaDAL;
        }

        public List<CategoriaBE> ObtenerActivas()
        {
        }

        public bool ValidarCategoria(CategoriaBE categoria)
        {
        }
    }
}