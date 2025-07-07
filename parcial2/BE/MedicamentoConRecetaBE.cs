using System;

namespace BE
{
    public class MedicamentoConRecetaBE : MedicamentoBE
    {
        public string TipoReceta { get; set; }
        public bool EsControlado { get; set; }
        public string Droga { get; set; }

        public MedicamentoConRecetaBE()
        {
        }

        public MedicamentoConRecetaBE(int id, string nombre, decimal precio, int stock, string tipoReceta) 
            : base(id, nombre, precio, stock)
        {
        }

        public override bool RequiereReceta()
        {
        }

        public bool ValidarRecetaVigente(DateTime fechaReceta)
        {
        }

        private bool VerificarControlado()
        {
        }

        protected override bool ValidarStock(int cantidadSolicitada)
        {
        }
    }
}