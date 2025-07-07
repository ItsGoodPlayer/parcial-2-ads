using System;

namespace BE
{
    public class PagoBE
    {
        private int id;
        private int ventaId;
        private MetodoPagoBE metodoPago;
        private decimal monto;
        private string numeroTarjeta;
        private string codigoAutorizacion;
        private DateTime fechaPago;
        private string estado;

        public PagoBE()
        {
        }

        public PagoBE(MetodoPagoBE metodoPago, decimal monto)
        {
            this.metodoPago = metodoPago;
            this.monto = monto;
            this.fechaPago = DateTime.Now;
            this.estado = "Pendiente";
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

        public MetodoPagoBE GetMetodoPago()
        {
            return metodoPago;
        }

        public void SetMetodoPago(MetodoPagoBE metodoPago)
        {
            this.metodoPago = metodoPago;
        }

        public decimal GetMonto()
        {
            return monto;
        }

        public void SetMonto(decimal monto)
        {
            this.monto = monto;
        }

        public string GetNumeroTarjeta()
        {
            return numeroTarjeta;
        }

        public void SetNumeroTarjeta(string numeroTarjeta)
        {
            this.numeroTarjeta = numeroTarjeta;
        }

        public string GetCodigoAutorizacion()
        {
            return codigoAutorizacion;
        }

        public void SetCodigoAutorizacion(string codigoAutorizacion)
        {
            this.codigoAutorizacion = codigoAutorizacion;
        }

        public DateTime GetFechaPago()
        {
            return fechaPago;
        }

        public void SetFechaPago(DateTime fechaPago)
        {
            this.fechaPago = fechaPago;
        }

        public string GetEstado()
        {
            return estado;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }
    }
}