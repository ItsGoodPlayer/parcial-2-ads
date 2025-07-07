using System;

namespace BE
{
    public class CategoriaBE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool RequiereRecetaMedica { get; set; }
        public int EdadMinimaVenta { get; set; }
        public bool EsActiva { get; set; }

        public CategoriaBE()
        {
        }

        public CategoriaBE(string nombre, bool requiereRecetaMedica)
        {
            Nombre = nombre;
            RequiereRecetaMedica = requiereRecetaMedica;
            EsActiva = true;
            EdadMinimaVenta = 0;
        }
    }
}