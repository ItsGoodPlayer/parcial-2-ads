using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public class MedicamentoDAL : BaseDAO<MedicamentoBE>
    {
        public MedicamentoDAL()
        {
        }

        public override List<MedicamentoBE> Listar()
        {
        }

        public List<MedicamentoBE> BuscarPorNombre(string nombre)
        {
        }

        public bool VerificarStock(int id, int cantidadRequerida)
        {
        }

        public void ActualizarStock(int id, int cantidadVendida)
        {
        }
    }
}