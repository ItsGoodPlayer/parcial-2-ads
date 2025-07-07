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

        public void ActualizarStock(List<DetalleVentaBE> detalles)
        {
        }
    }
}