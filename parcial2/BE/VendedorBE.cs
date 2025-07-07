using System;

namespace BE
{
    public class VendedorBE : UsuarioBE
    {
        private string legajo;
        private string sucursal;
        private decimal porcentajeComision;
        private DateTime fechaIngreso;
        private string turno;

        public VendedorBE()
        {
        }

        public VendedorBE(string dni, string nombre, string apellido, string legajo, string sucursal) 
            : base(dni, nombre, apellido)
        {
            this.legajo = legajo;
            this.sucursal = sucursal;
            this.fechaIngreso = DateTime.Now;
            this.porcentajeComision = 0.02m; // 2% por defecto
        }

        public override string ObtenerTipoUsuario()
        {
            return "Vendedor";
        }

        public override string NombreCompleto()
        {
            return $"{base.NombreCompleto()} - Legajo: {legajo}";
        }

        public string GetLegajo()
        {
            return legajo;
        }

        public void SetLegajo(string legajo)
        {
            this.legajo = legajo;
        }

        public string GetSucursal()
        {
            return sucursal;
        }

        public void SetSucursal(string sucursal)
        {
            this.sucursal = sucursal;
        }

        public decimal GetPorcentajeComision()
        {
            return porcentajeComision;
        }

        public void SetPorcentajeComision(decimal porcentajeComision)
        {
            this.porcentajeComision = porcentajeComision;
        }

        public DateTime GetFechaIngreso()
        {
            return fechaIngreso;
        }

        public void SetFechaIngreso(DateTime fechaIngreso)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public string GetTurno()
        {
            return turno;
        }

        public void SetTurno(string turno)
        {
            this.turno = turno;
        }
    }
}