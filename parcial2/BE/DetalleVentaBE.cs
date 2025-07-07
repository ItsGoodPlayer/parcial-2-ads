using System;

namespace BE
{
    public class DetalleVentaBE
    {
        private int id;
        private int ventaId;
        private MedicamentoBE medicamento;
        private int cantidad;
        private decimal precioUnitario;
        private decimal subtotal;
        private RecetaBE receta;

        public DetalleVentaBE()
        {
        }

        public DetalleVentaBE(MedicamentoBE medicamento, int cantidad)
        {
            this.medicamento = medicamento;
            this.cantidad = cantidad;
            this.precioUnitario = medicamento.GetPrecio();
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetVentaId()
        {
            return ventaId;
        }

        public void SetVentaId(int ventaId)
        {
            this.ventaId = ventaId;
        }

        public MedicamentoBE GetMedicamento()
        {
            return medicamento;
        }

        public void SetMedicamento(MedicamentoBE medicamento)
        {
            this.medicamento = medicamento;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public decimal GetPrecioUnitario()
        {
            return precioUnitario;
        }

        public void SetPrecioUnitario(decimal precioUnitario)
        {
            this.precioUnitario = precioUnitario;
        }

        public decimal GetSubtotal()
        {
            return subtotal;
        }

        public void SetSubtotal(decimal subtotal)
        {
            this.subtotal = subtotal;
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