using System;

namespace BE
{
    public class ObraSocialBE
    {
        private int id;
        private string nombre;
        private string codigo;
        private decimal porcentajeDescuento;
        private bool esActiva;
        private string tipoCobertura;

        public ObraSocialBE()
        {
        }

        public ObraSocialBE(string nombre, string codigo, decimal porcentajeDescuento)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.porcentajeDescuento = porcentajeDescuento;
            this.esActiva = true;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public decimal GetPorcentajeDescuento()
        {
            return porcentajeDescuento;
        }

        public void SetPorcentajeDescuento(decimal porcentajeDescuento)
        {
            this.porcentajeDescuento = porcentajeDescuento;
        }

        public bool GetEsActiva()
        {
            return esActiva;
        }

        public void SetEsActiva(bool esActiva)
        {
            this.esActiva = esActiva;
        }

        public string GetTipoCobertura()
        {
            return tipoCobertura;
        }

        public void SetTipoCobertura(string tipoCobertura)
        {
            this.tipoCobertura = tipoCobertura;
        }
    }
}