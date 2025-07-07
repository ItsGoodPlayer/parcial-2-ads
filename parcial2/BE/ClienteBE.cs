using System;

namespace BE
{
    public class ClienteBE : UsuarioBE
    {
        public DateTime FechaNacimiento { get; set; }
        public ObraSocialBE ObraSocial { get; set; }
        public string NumeroAfiliado { get; set; }
        public bool TieneDescuentoTerceraEdad { get; set; }

        public ClienteBE()
        {
        }

        public ClienteBE(string dni, string nombre, string apellido, DateTime fechaNacimiento) 
            : base(dni, nombre, apellido)
        {
            FechaNacimiento = fechaNacimiento;
            TieneDescuentoTerceraEdad = CalcularEsTerceraEdad();
        }

        public override string ObtenerTipoUsuario()
        {
            return "Cliente";
        }

        public int CalcularEdad()
        {
            var today = DateTime.Today;
            var age = today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > today.AddYears(-age)) age--;
            return age;
        }

        private bool CalcularEsTerceraEdad()
        {
            return CalcularEdad() >= 65;
        }
    }
}