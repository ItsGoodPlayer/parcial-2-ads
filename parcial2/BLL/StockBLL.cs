using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class StockBLL : ValidadorBaseBLL
    {
        private StockDAL stockDAL;
        private MedicamentoDAL medicamentoDAL;

        public StockBLL()
        {
        }

        public StockBLL(StockDAL stockDAL, MedicamentoDAL medicamentoDAL)
        {
        }

        public override bool Validar(object objeto)
        {
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

        protected override bool ValidarDatosObligatorios(object objeto)
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