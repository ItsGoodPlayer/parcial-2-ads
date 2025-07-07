using System;

namespace BE
{
    public class LaboratorioBE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public bool EsActivo { get; set; }

        public LaboratorioBE()
        {
        }

        public LaboratorioBE(string nombre, string pais)
        {
            Nombre = nombre;
            Pais = pais;
            EsActivo = true;
        }
    }
}