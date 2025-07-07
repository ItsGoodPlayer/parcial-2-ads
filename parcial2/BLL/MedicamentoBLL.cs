using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class MedicamentoBLL : ValidadorBaseBLL
    {
        private MedicamentoDAL medicamentoDAL;
        private StockDAL stockDAL;

        public MedicamentoBLL()
        {
        }

        public MedicamentoBLL(MedicamentoDAL medicamentoDAL, StockDAL stockDAL)
        {
        }

        public override bool Validar(object objeto)
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

        protected override bool ValidarDatosObligatorios(object objeto)
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