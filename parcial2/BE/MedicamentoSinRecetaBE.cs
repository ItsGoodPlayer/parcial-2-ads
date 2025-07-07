using System;

namespace BE
{
    public class MedicamentoSinRecetaBE : MedicamentoBE
    {
        public int EdadMinima { get; set; }
        public string Indicaciones { get; set; }

        public MedicamentoSinRecetaBE()
        {
        }

        public MedicamentoSinRecetaBE(int id, string nombre, decimal precio, int stock) 
            : base(id, nombre, precio, stock)
        {
        }

        public override bool RequiereReceta()
        {
            return false;
        }
    }
}