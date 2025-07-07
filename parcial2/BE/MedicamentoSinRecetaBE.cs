using System;

namespace BE
{
    public class MedicamentoSinRecetaBE : MedicamentoBE
    {
        public string Categoria { get; set; }
        public int EdadMinima { get; set; }
        public string Indicaciones { get; set; }

        public MedicamentoSinRecetaBE()
        {
        }

        public MedicamentoSinRecetaBE(int id, string nombre, decimal precio, int stock, string categoria) 
            : base(id, nombre, precio, stock)
        {
        }

        public override bool RequiereReceta()
        {
        }

        public bool ValidarEdadMinima(int edadPaciente)
        {
        }

        private bool VerificarVentaLibre()
        {
        }

        public override decimal CalcularPrecioTotal(int cantidad)
        {
        }
    }
}