using System;

namespace BE
{
    public interface IDescuentoBE
    {
        decimal CalcularDescuento(decimal montoBase);
        bool EsAplicable(VentaBE venta);
        string ObtenerDescripcion();
    }
}