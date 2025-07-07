using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class PagoBLL
    {
        private PagoDAL pagoDAL;
        private MetodoPagoDAL metodoPagoDAL;

        public PagoBLL()
        {
            pagoDAL = new PagoDAL();
            metodoPagoDAL = new MetodoPagoDAL();
        }

        public PagoBLL(PagoDAL pagoDAL, MetodoPagoDAL metodoPagoDAL)
        {
            this.pagoDAL = pagoDAL;
            this.metodoPagoDAL = metodoPagoDAL;
        }

        public bool ProcesarPago(PagoBE pago)
        {
        }

        public bool ValidarPago(PagoBE pago)
        {
        }

        public bool ValidarMontoSuficiente(VentaBE venta, List<PagoBE> pagos)
        {
        }

        public decimal CalcularMontoTotal(List<PagoBE> pagos)
        {
        }

        public bool AutorizarPagoTarjeta(PagoBE pago)
        {
        }

        public List<MetodoPagoBE> ObtenerMetodosPagoDisponibles()
        {
        }

        public bool GuardarPago(PagoBE pago)
        {
        }

        public bool ActualizarEstadoPago(int pagoId, string estado)
        {
        }

        public decimal CalcularComision(PagoBE pago)
        {
        }

        private bool ValidarDatosPago(PagoBE pago)
        {
        }

        private bool ValidarMetodoPago(MetodoPagoBE metodoPago)
        {
        }

        private bool ValidarTarjeta(string numeroTarjeta)
        {
        }

        protected string GenerarCodigoAutorizacion()
        {
        }

        protected bool ProcesarPagoEfectivo(PagoBE pago)
        {
        }

        protected bool ProcesarPagoTarjeta(PagoBE pago)
        {
        }
    }
}