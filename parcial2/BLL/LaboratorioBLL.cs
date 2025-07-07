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

        public bool ValidarLaboratorio(LaboratorioBE laboratorio)
        {
        }

        public List<LaboratorioBE> ObtenerTodos()
        {
        }

        public List<LaboratorioBE> ObtenerActivos()
        {
        }

        public LaboratorioBE ObtenerPorId(int id)
        {
        }

        public LaboratorioBE ObtenerPorNombre(string nombre)
        {
        }

        public List<LaboratorioBE> BuscarPorPais(string pais)
        {
        }

        public bool GuardarLaboratorio(LaboratorioBE laboratorio)
        {
        }

        public bool ActualizarLaboratorio(LaboratorioBE laboratorio)
        {
        }

        private bool ValidarDatosObligatorios(LaboratorioBE laboratorio)
        {
        }

        private bool ValidarNombreUnico(string nombre, int laboratorioId = 0)
        {
        }

        private bool ValidarEmail(string email)
        {
        }

        protected bool ValidarTelefono(string telefono)
        {
        }
    }
}