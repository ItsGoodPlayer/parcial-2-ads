using System;

namespace BE
{
    public abstract class MedicamentoBE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Laboratorio { get; set; }

        protected MedicamentoBE()
        {
        }

        protected MedicamentoBE(int id, string nombre, decimal precio, int stock)
        {
        }

        public abstract bool RequiereReceta();
        
        protected virtual bool ValidarStock(int cantidadSolicitada)
        {
        }

        public virtual decimal CalcularPrecioTotal(int cantidad)
        {
        }
    }
}