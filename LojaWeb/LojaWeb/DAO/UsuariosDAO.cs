﻿using LojaWeb.Entidades;
using NHibernate;
using System.Collections.Generic;

namespace LojaWeb.DAO
{
    public class UsuariosDAO
    {
        private ISession session;

        public UsuariosDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Usuario usuario)
        {

        }

        public void Remove(Usuario usuario)
        {

        }

        public void Atualiza(Usuario usuario)
        {

        }

        public Usuario BuscaPorId(int id)
        {
            return null;
        }

        public IList<Usuario> Lista()
        {
            return new List<Usuario>();
        }
    }
}