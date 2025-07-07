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

        public bool ValidarCategoria(CategoriaBE categoria)
        {
        }

        public List<CategoriaBE> ObtenerTodas()
        {
        }

        public List<CategoriaBE> ObtenerActivas()
        {
        }

        public CategoriaBE ObtenerPorId(int id)
        {
        }

        public CategoriaBE ObtenerPorNombre(string nombre)
        {
        }

        public List<CategoriaBE> ObtenerPorTipoReceta(bool requiereReceta)
        {
        }

        public bool GuardarCategoria(CategoriaBE categoria)
        {
        }

        public bool ActualizarCategoria(CategoriaBE categoria)
        {
        }

        public bool ValidarEdadMinima(CategoriaBE categoria, int edadPaciente)
        {
        }

        private bool ValidarDatosObligatorios(CategoriaBE categoria)
        {
        }

        private bool ValidarNombreUnico(string nombre, int categoriaId = 0)
        {
        }

        private bool ValidarEdadMinimaValida(int edadMinima)
        {
        }

        protected bool EsCategoriaConReceta(CategoriaBE categoria)
        {
        }
    }
}