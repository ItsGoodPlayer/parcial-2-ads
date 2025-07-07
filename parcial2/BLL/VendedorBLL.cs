using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class VendedorBLL : UsuarioBLL
    {
        private VendedorDAL vendedorDAL;

        public VendedorBLL() : base(new VendedorDAL())
        {
            vendedorDAL = new VendedorDAL();
        }

        public VendedorBLL(VendedorDAL vendedorDAL) : base(vendedorDAL)
        {
            this.vendedorDAL = vendedorDAL;
        }

        public override bool ValidarUsuario(UsuarioBE usuario)
        {
        }

        public VendedorBE ObtenerPorLegajo(string legajo)
        {
        }

        public bool ValidarLegajoUnico(string legajo, int vendedorId = 0)
        {
        }

        public decimal CalcularComision(VendedorBE vendedor, decimal montoVenta)
        {
        }
    }
}