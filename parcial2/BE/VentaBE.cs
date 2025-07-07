using System;
using System.Collections.Generic;

namespace BE
{
    public class VentaBE
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoFinal { get; set; }
        public string Estado { get; set; }
        public List<DetalleVentaBE> Detalles { get; set; }

        public VentaBE()
        {
        }

        public VentaBE(DateTime fecha)
        {
        }

        public void AgregarDetalle(DetalleVentaBE detalle)
        {
        }

        public decimal CalcularMontoTotal()
        {
        }

        public void AplicarDescuento(decimal montoDescuento)
        {
        }

        private bool ValidarEstado()
        {
        }

        public List<MedicamentoBE> ObtenerMedicamentosConReceta()
        {
        }
    }
}