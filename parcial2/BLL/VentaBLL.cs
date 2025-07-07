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

        public decimal CalcularDescuentos(VentaBE venta)
        {
        }

        public bool ProcesarPago(VentaBE venta, List<PagoBE> pagos)
        {
        }
    }
}