using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class DescuentoBLL : IDescuentoBE
    {
        private ObraSocialDAL obraSocialDAL;

        public DescuentoBLL()
        {
        }

        public DescuentoBLL(ObraSocialDAL obraSocialDAL)
        {
        }

        public decimal CalcularDescuento(decimal montoBase)
        {
        }

        public bool EsAplicable(VentaBE venta)
        {
        }

        public string ObtenerDescripcion()
        {
        }

        public decimal AplicarDescuentoObraSocial(VentaBE venta)
        {
        }

        public decimal CalcularDescuentoTotal(VentaBE venta)
        {
        }

        public List<IDescuentoBE> ObtenerDescuentosAplicables(VentaBE venta)
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