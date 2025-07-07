using System;
using System.Collections.Generic;
using BE;

namespace DAL
{
    public abstract class UsuarioDAL : BaseDAO<UsuarioBE>
    {
        protected UsuarioDAL()
        {
        }

        public override List<UsuarioBE> Listar()
        {
        }

        public UsuarioBE ObtenerPorDNI(string dni)
        {
        }

        public bool ExisteDNI(string dni)
        {
        }

        public List<UsuarioBE> ObtenerActivos()
        {
        }
    }
}