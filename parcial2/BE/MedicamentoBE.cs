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
        public LaboratorioBE Laboratorio { get; set; }
        public CategoriaBE Categoria { get; set; }

        protected MedicamentoBE()
        {
        }

        protected MedicamentoBE(int id, string nombre, decimal precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public abstract bool RequiereReceta();
    }
}