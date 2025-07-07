using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class VentaBLL : ValidadorBaseBLL
    {
        private VentaDAL ventaDAL;
        private MedicamentoBLL medicamentoBLL;
        private StockBLL stockBLL;
        private DescuentoBLL descuentoBLL;

        public VentaBLL()
        {
        }

        public VentaBLL(VentaDAL ventaDAL, MedicamentoBLL medicamentoBLL, StockBLL stockBLL, DescuentoBLL descuentoBLL)
        {
        }

        public override bool Validar(object objeto)
        {
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

        protected override bool ValidarDatosObligatorios(object objeto)
        {
        }

        private bool ValidarDetallesVenta(List<DetalleVentaBE> detalles)
        {
        }

        private bool ValidarMedicamentosExistentes(List<DetalleVentaBE> detalles)
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