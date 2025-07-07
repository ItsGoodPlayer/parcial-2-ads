using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class VentaBLL
    {
        private VentaDAL ventaDAL;
        private MedicamentoBLL medicamentoBLL;
        private StockBLL stockBLL;
        private DescuentoBLL descuentoBLL;
        private RecetaBLL recetaBLL;
        private PagoBLL pagoBLL;

        public VentaBLL()
        {
            ventaDAL = new VentaDAL();
            medicamentoBLL = new MedicamentoBLL();
            stockBLL = new StockBLL();
            descuentoBLL = new DescuentoBLL();
            recetaBLL = new RecetaBLL();
            pagoBLL = new PagoBLL();
        }

        public VentaBLL(VentaDAL ventaDAL, MedicamentoBLL medicamentoBLL, StockBLL stockBLL, DescuentoBLL descuentoBLL, RecetaBLL recetaBLL, PagoBLL pagoBLL)
        {
            this.ventaDAL = ventaDAL;
            this.medicamentoBLL = medicamentoBLL;
            this.stockBLL = stockBLL;
            this.descuentoBLL = descuentoBLL;
            this.recetaBLL = recetaBLL;
            this.pagoBLL = pagoBLL;
        }

        public bool ProcesarVenta(VentaBE venta)
        {
        }

        public List<MedicamentoBE> ObtenerMedicamentosConReceta(VentaBE venta)
        {
        }

        public bool ValidarStock(List<DetalleVentaBE> detalles)
        {
        }

        public decimal CalcularDescuentos(VentaBE venta)
        {
        }

        public bool GuardarVenta(VentaBE venta)
        {
        }

        public void AgregarDetalle(VentaBE venta, DetalleVentaBE detalle)
        {
        }

        public decimal CalcularSubtotal(DetalleVentaBE detalle)
        {
        }

        public bool ValidarVenta(VentaBE venta)
        {
        }

        public bool ProcesarPago(VentaBE venta, List<PagoBE> pagos)
        {
        }

        public bool ValidarPagos(VentaBE venta, List<PagoBE> pagos)
        {
        }

        public void AgregarPago(VentaBE venta, PagoBE pago)
        {
        }

        public List<MetodoPagoBE> ObtenerMetodosPagoDisponibles()
        {
        }

        private bool ValidarDetallesVenta(List<DetalleVentaBE> detalles)
        {
        }

        private bool ValidarMedicamentosExistentes(List<DetalleVentaBE> detalles)
        {
        }

        private bool ValidarRecetasNecesarias(List<DetalleVentaBE> detalles)
        {
        }

        private bool ValidarMontosSuficientes(VentaBE venta, List<PagoBE> pagos)
        {
        }

        protected void ActualizarStock(List<DetalleVentaBE> detalles)
        {
        }

        protected decimal CalcularMontoTotal(List<DetalleVentaBE> detalles)
        {
        }
    }
}