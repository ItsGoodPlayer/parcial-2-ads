using System;

namespace BE
{
    public class VendedorBE : UsuarioBE
    {
        public string Legajo { get; set; }
        public string Sucursal { get; set; }
        public decimal PorcentajeComision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Turno { get; set; }

        public VendedorBE()
        {
        }

        public VendedorBE(string dni, string nombre, string apellido, string legajo, string sucursal) 
            : base(dni, nombre, apellido)
        {
            Legajo = legajo;
            Sucursal = sucursal;
            FechaIngreso = DateTime.Now;
            PorcentajeComision = 0.02m; // 2% por defecto
        }

        public override string ObtenerTipoUsuario()
        {
            return "Vendedor";
        }

        public override string NombreCompleto()
        {
            return $"{base.NombreCompleto()} - Legajo: {Legajo}";
        }
    }
}