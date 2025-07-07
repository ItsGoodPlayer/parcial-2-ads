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

        public bool ValidarMedicamento(MedicamentoBE medicamento)
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

        public bool VerificarStock(int medicamentoId, int cantidadRequerida)
        {
        }

        public List<MedicamentoBE> FiltrarMedicamentosConReceta(List<MedicamentoBE> medicamentos)
        {
        }

        public List<MedicamentoBE> BuscarPorNombre(string nombre)
        {
        }

        public decimal CalcularPrecioTotal(MedicamentoBE medicamento, int cantidad)
        {
        }

        private bool ValidarDatosObligatorios(MedicamentoBE medicamento)
        {
        }

        private bool ValidarPrecio(decimal precio)
        {
        }

        private bool ValidarStock(int stock)
        {
        }

        protected bool ValidarMedicamentoExistente(int id)
        {
        }
    }
}