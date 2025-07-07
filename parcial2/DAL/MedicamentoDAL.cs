using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public class MedicamentoDAL
    {
        private string connectionString;

        public MedicamentoDAL()
        {
        }

        public MedicamentoDAL(string connectionString)
        {
        }

        public List<MedicamentoBE> ObtenerTodos()
        {
        }

        public MedicamentoBE ObtenerPorId(int id)
        {
        }

        public bool ExisteMedicamento(int id)
        {
        }

        public bool VerificarStock(int id, int cantidadRequerida)
        {
        }

        public void ActualizarStock(int id, int cantidadVendida)
        {
        }

        public List<MedicamentoBE> BuscarPorNombre(string nombre)
        {
        }

        private string ObtenerQueryBase()
        {
        }

        protected void ValidarConexion()
        {
        }
    }
}