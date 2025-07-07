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

        public bool ValidarMontoSuficiente(VentaBE venta, List<PagoBE> pagos)
        {
        }

        public List<MetodoPagoBE> ObtenerMetodosPagoDisponibles()
        {
        }
    }
}