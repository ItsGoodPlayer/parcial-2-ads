using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class DescuentoBLL
    {
        private ObraSocialDAL obraSocialDAL;

        public DescuentoBLL()
        {
            obraSocialDAL = new ObraSocialDAL();
        }

        public DescuentoBLL(ObraSocialDAL obraSocialDAL)
        {
            this.obraSocialDAL = obraSocialDAL;
        }

        public decimal CalcularDescuentoObraSocial(VentaBE venta, ObraSocialBE obraSocial)
        {
        }

        public decimal AplicarDescuentoObraSocial(VentaBE venta)
        {
        }

        public decimal CalcularDescuentoTotal(VentaBE venta)
        {
        }

        public bool EsAplicableDescuento(VentaBE venta, ObraSocialBE obraSocial)
        {
        }

        public decimal BuscarDescuentoPorObraSocial(int obraSocialId)
        {
        }

        public decimal AplicarDescuentoPorDetalle(DetalleVentaBE detalle, decimal porcentajeDescuento)
        {
        }

        private bool ValidarMontoMinimo(decimal monto)
        {
        }

        private decimal AplicarLimitesDescuento(decimal descuento, decimal montoBase)
        {
        }

        protected bool TieneRecetasConObraSocial(VentaBE venta)
        {
        }

        protected decimal CalcularDescuentoPorDetalle(DetalleVentaBE detalle)
        {
        }
    }
}