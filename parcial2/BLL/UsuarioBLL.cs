using System;
using System.Collections.Generic;
using BE;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        protected UsuarioDAL usuarioDAL;

        public UsuarioBLL(UsuarioDAL usuarioDAL)
        {
            this.usuarioDAL = usuarioDAL;
        }

        public virtual bool ValidarUsuario(UsuarioBE usuario)
        {
        }

        public UsuarioBE ObtenerPorDNI(string dni)
        {
        }

        public bool ValidarDNIUnico(string dni, int usuarioId = 0)
        {
        }

        protected bool ValidarDatosObligatorios(UsuarioBE usuario)
        {
        }
    }
}