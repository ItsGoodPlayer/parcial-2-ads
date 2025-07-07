using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public class StockDAL
    {
        private string connectionString;

        public StockDAL()
        {
        }

        public StockDAL(string connectionString)
        {
        }

        public int ObtenerStockDisponible(int medicamentoId)
        {
        }

        public bool HayStock(int medicamentoId, int cantidadRequerida)
        {
        }

        public void ReservarStock(int medicamentoId, int cantidad)
        {
        }

        public void ConfirmarVenta(int medicamentoId, int cantidad)
        {
        }

        public void LiberarStock(int medicamentoId, int cantidad)
        {
        }

        public Dictionary<int, int> VerificarStockMultiple(List<int> medicamentosIds)
        {
        }

        private bool ValidarStockMinimo(int medicamentoId)
        {
        }

        protected void ActualizarStockFisico(int medicamentoId, int nuevaCantidad)
        {
        }

        protected void RegistrarMovimientoStock(int medicamentoId, int cantidad, string tipo)
        {
        }
    }
}