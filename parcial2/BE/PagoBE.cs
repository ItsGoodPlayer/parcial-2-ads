using System;

namespace BE
{
    public class PagoBE
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public MetodoPagoBE MetodoPago { get; set; }
        public decimal Monto { get; set; }
        public string NumeroTarjeta { get; set; }
        public string CodigoAutorizacion { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }

        public PagoBE()
        {
        }

        public PagoBE(MetodoPagoBE metodoPago, decimal monto)
        {
            MetodoPago = metodoPago;
            Monto = monto;
            FechaPago = DateTime.Now;
            Estado = "Pendiente";
        }
    }
}