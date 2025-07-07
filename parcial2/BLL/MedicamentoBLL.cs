using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class MedicamentoBLL
    {
        private MedicamentoDAL medicamentoDAL;
        private StockDAL stockDAL;

        public MedicamentoBLL()
        {
            medicamentoDAL = new MedicamentoDAL();
            stockDAL = new StockDAL();
        }

        public MedicamentoBLL(MedicamentoDAL medicamentoDAL, StockDAL stockDAL)
        {
            this.medicamentoDAL = medicamentoDAL;
            this.stockDAL = stockDAL;
        }

        public List<MedicamentoBE> ObtenerTodos()
        {
        }

        public bool ValidarMedicamento(MedicamentoBE medicamento)
        {
        }

        public bool VerificarStock(int medicamentoId, int cantidadRequerida)
        {
        }

        public List<MedicamentoBE> FiltrarMedicamentosConReceta(List<MedicamentoBE> medicamentos)
        {
        }
    }
}