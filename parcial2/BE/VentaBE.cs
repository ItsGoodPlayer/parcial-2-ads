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
        public List<PagoBE> Pagos { get; set; }
        public string FormaPago { get; set; }
        public VendedorBE Vendedor { get; set; }
        public ClienteBE Cliente { get; set; }

        public VentaBE()
        {
            Detalles = new List<DetalleVentaBE>();
            Pagos = new List<PagoBE>();
        }

        public VentaBE(DateTime fecha)
        {
            Fecha = fecha;
            Detalles = new List<DetalleVentaBE>();
            Pagos = new List<PagoBE>();
        }
    }
}