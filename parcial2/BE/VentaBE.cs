using System;
using System.Collections.Generic;

namespace BE
{
    public class VentaBE
    {
        private int id;
        private DateTime fecha;
        private decimal montoTotal;
        private decimal montoDescuento;
        private decimal montoFinal;
        private string estado;
        private List<DetalleVentaBE> detalles;
        private List<PagoBE> pagos;
        private string formaPago;
        private VendedorBE vendedor;
        private ClienteBE cliente;

        public VentaBE()
        {
            detalles = new List<DetalleVentaBE>();
            pagos = new List<PagoBE>();
        }

        public VentaBE(DateTime fecha)
        {
            this.fecha = fecha;
            detalles = new List<DetalleVentaBE>();
            pagos = new List<PagoBE>();
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }

        public void SetFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public decimal GetMontoTotal()
        {
            return montoTotal;
        }

        public void SetMontoTotal(decimal montoTotal)
        {
            this.montoTotal = montoTotal;
        }

        public decimal GetMontoDescuento()
        {
            return montoDescuento;
        }

        public void SetMontoDescuento(decimal montoDescuento)
        {
            this.montoDescuento = montoDescuento;
        }

        public decimal GetMontoFinal()
        {
            return montoFinal;
        }

        public void SetMontoFinal(decimal montoFinal)
        {
            this.montoFinal = montoFinal;
        }

        public string GetEstado()
        {
            return estado;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }

        public List<DetalleVentaBE> GetDetalles()
        {
            return detalles;
        }

        public void SetDetalles(List<DetalleVentaBE> detalles)
        {
            this.detalles = detalles;
        }

        public List<PagoBE> GetPagos()
        {
            return pagos;
        }

        public void SetPagos(List<PagoBE> pagos)
        {
            this.pagos = pagos;
        }

        public string GetFormaPago()
        {
            return formaPago;
        }

        public void SetFormaPago(string formaPago)
        {
            this.formaPago = formaPago;
        }

        public VendedorBE GetVendedor()
        {
            return vendedor;
        }

        public void SetVendedor(VendedorBE vendedor)
        {
            this.vendedor = vendedor;
        }

        public ClienteBE GetCliente()
        {
            return cliente;
        }

        public void SetCliente(ClienteBE cliente)
        {
            this.cliente = cliente;
        }
    }
}