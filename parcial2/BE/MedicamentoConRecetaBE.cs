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
            TipoReceta = tipoReceta;
        }

        public override bool RequiereReceta()
        {
            return true;
        }
    }
}