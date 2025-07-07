using System;

namespace BE
{
    public class ClienteBE : UsuarioBE
    {
        private DateTime fechaNacimiento;
        private ObraSocialBE obraSocial;
        private string numeroAfiliado;
        private bool tieneDescuentoTerceraEdad;

        public ClienteBE()
        {
        }

        public ClienteBE(string dni, string nombre, string apellido, DateTime fechaNacimiento) 
            : base(dni, nombre, apellido)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.tieneDescuentoTerceraEdad = CalcularEsTerceraEdad();
        }

        public override string ObtenerTipoUsuario()
        {
            return "Cliente";
        }

        public int CalcularEdad()
        {
            var today = DateTime.Today;
            var age = today.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > today.AddYears(-age)) age--;
            return age;
        }

        private bool CalcularEsTerceraEdad()
        {
            return CalcularEdad() >= 65;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public ObraSocialBE GetObraSocial()
        {
            return obraSocial;
        }

        public void SetObraSocial(ObraSocialBE obraSocial)
        {
            this.obraSocial = obraSocial;
        }

        public string GetNumeroAfiliado()
        {
            return numeroAfiliado;
        }

        public void SetNumeroAfiliado(string numeroAfiliado)
        {
            this.numeroAfiliado = numeroAfiliado;
        }

        public bool GetTieneDescuentoTerceraEdad()
        {
            return tieneDescuentoTerceraEdad;
        }

        public void SetTieneDescuentoTerceraEdad(bool tieneDescuentoTerceraEdad)
        {
            this.tieneDescuentoTerceraEdad = tieneDescuentoTerceraEdad;
        }
    }
}