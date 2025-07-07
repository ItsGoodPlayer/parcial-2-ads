using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class ClienteBLL : UsuarioBLL
    {
        private ClienteDAL clienteDAL;

        public ClienteBLL() : base(new ClienteDAL())
        {
            clienteDAL = new ClienteDAL();
        }

        public ClienteBLL(ClienteDAL clienteDAL) : base(clienteDAL)
        {
            this.clienteDAL = clienteDAL;
        }

        public override bool ValidarUsuario(UsuarioBE usuario)
        {
        }

        public bool ValidarEdadMinima(ClienteBE cliente, int edadMinima)
        {
        }

        public bool TieneObraSocial(ClienteBE cliente)
        {
        }

        public decimal CalcularDescuentoTerceraEdad(ClienteBE cliente, decimal monto)
        {
        }
    }
}