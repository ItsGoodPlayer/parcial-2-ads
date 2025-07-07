using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class StockBLL
    {
        private StockDAL stockDAL;
        private MedicamentoDAL medicamentoDAL;

        public StockBLL()
        {
            stockDAL = new StockDAL();
            medicamentoDAL = new MedicamentoDAL();
        }

        public StockBLL(StockDAL stockDAL, MedicamentoDAL medicamentoDAL)
        {
            this.stockDAL = stockDAL;
            this.medicamentoDAL = medicamentoDAL;
        }

        public bool VerificarStock(int medicamentoId, int cantidadRequerida)
        {
        }

        public bool VerificarStockMultiple(List<DetalleVentaBE> detalles)
        {
        }

        public void ReservarStock(List<DetalleVentaBE> detalles)
        {
        }

        public void ConfirmarVenta(List<DetalleVentaBE> detalles)
        {
        }

        public void LiberarStock(List<DetalleVentaBE> detalles)
        {
        }

        public int ObtenerStockDisponible(int medicamentoId)
        {
        }

        public bool ValidarStockSuficiente(DetalleVentaBE detalle)
        {
        }

        public List<int> ObtenerMedicamentosConStockBajo(int stockMinimo)
        {
        }

        private bool ValidarCantidadSolicitada(int cantidad)
        {
        }

        private bool ValidarMedicamentoExistente(int medicamentoId)
        {
        }

        protected void ActualizarStockFisico(int medicamentoId, int cantidadVendida)
        {
        }

        protected void RegistrarMovimiento(int medicamentoId, int cantidad, string tipoMovimiento)
        {
        }
    }
}