using System;

namespace BE
{
    public class DetalleVentaBE
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public MedicamentoBE Medicamento { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public RecetaBE Receta { get; set; }

        public DetalleVentaBE()
        {
        }

        public DetalleVentaBE(MedicamentoBE medicamento, int cantidad)
        {
            Medicamento = medicamento;
            Cantidad = cantidad;
            PrecioUnitario = medicamento.Precio;
        }
    }
}