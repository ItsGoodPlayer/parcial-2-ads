using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class MedicamentoDAL : BaseDAO<MedicamentoBE>
    {
        public MedicamentoDAL() : base("Medicamentos")
        {
        }

        public bool VerificarStock(int id, int cantidadRequerida)
        {
        }

        public void ActualizarStock(int id, int cantidadVendida)
        {
        }

        public List<MedicamentoBE> BuscarPorNombre(string nombre)
        {
        }

        public List<MedicamentoBE> ObtenerMedicamentosConReceta()
        {
        }

        public List<MedicamentoBE> ObtenerMedicamentosSinReceta()
        {
        }

        protected override MedicamentoBE MapearEntidad(DataRow row)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosInsertar(MedicamentoBE entidad)
        {
        }

        protected override List<SqlParameter> ObtenerParametrosActualizar(MedicamentoBE entidad)
        {
        }

        protected override string ObtenerQueryInsertar()
        {
        }

        protected override string ObtenerQueryActualizar()
        {
        }

        private MedicamentoBE CrearMedicamentoSegunTipo(DataRow row)
        {
        }

        private List<SqlParameter> ObtenerParametrosComunes(MedicamentoBE medicamento)
        {
        }
    }
}