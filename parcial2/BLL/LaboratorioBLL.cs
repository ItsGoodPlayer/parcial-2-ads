using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class LaboratorioBLL
    {
        private LaboratorioDAL laboratorioDAL;

        public LaboratorioBLL()
        {
            laboratorioDAL = new LaboratorioDAL();
        }

        public LaboratorioBLL(LaboratorioDAL laboratorioDAL)
        {
            this.laboratorioDAL = laboratorioDAL;
        }

        public List<LaboratorioBE> ObtenerActivos()
        {
        }

        public bool ValidarLaboratorio(LaboratorioBE laboratorio)
        {
        }
    }
}