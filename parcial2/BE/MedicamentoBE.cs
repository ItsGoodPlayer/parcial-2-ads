using System;

namespace BE
{
    public class MedicamentoBE
    {
        private int id;
        private string nombre;
        private string descripcion;
        private decimal precio;
        private int stock;
        private LaboratorioBE laboratorio;
        private CategoriaBE categoria;
        private bool requiereReceta;

        public MedicamentoBE()
        {
        }

        public MedicamentoBE(int id, string nombre, decimal precio, int stock, bool requiereReceta)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.requiereReceta = requiereReceta;
        }

        public bool RequiereReceta()
        {
            return requiereReceta;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public decimal GetPrecio()
        {
            return precio;
        }

        public void SetPrecio(decimal precio)
        {
            this.precio = precio;
        }

        public int GetStock()
        {
            return stock;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public LaboratorioBE GetLaboratorio()
        {
            return laboratorio;
        }

        public void SetLaboratorio(LaboratorioBE laboratorio)
        {
            this.laboratorio = laboratorio;
        }

        public CategoriaBE GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(CategoriaBE categoria)
        {
            this.categoria = categoria;
        }

        public bool GetRequiereReceta()
        {
            return requiereReceta;
        }

        public void SetRequiereReceta(bool requiereReceta)
        {
            this.requiereReceta = requiereReceta;
        }
    }
}