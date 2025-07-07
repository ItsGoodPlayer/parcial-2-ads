using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public class StockDAL : BaseDAO<object>
    {
        public StockDAL()
        {
        }

        public override List<object> Listar()
        {
        }

        public int ObtenerStockDisponible(int medicamentoId)
        {
        }

        public bool HayStock(int medicamentoId, int cantidadRequerida)
        {
        }

        public void ActualizarStock(int medicamentoId, int cantidadVendida)
        {
        }
    }
}