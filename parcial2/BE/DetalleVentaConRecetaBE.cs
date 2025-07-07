using System;

namespace BE
{
    public class DetalleVentaConRecetaBE : DetalleVentaBE
    {
        private RecetaBE receta;

        public DetalleVentaConRecetaBE()
        {
        }

        public DetalleVentaConRecetaBE(MedicamentoBE medicamento, int cantidad, RecetaBE receta) 
            : base(medicamento, cantidad)
        {
            this.receta = receta;
        }

        public RecetaBE GetReceta()
        {
            return receta;
        }

        public void SetReceta(RecetaBE receta)
        {
            this.receta = receta;
        }
    }
}