﻿using BancoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Repositorio
{
    public interface IUsuarioRepositorio
    {

        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuarioModel);
        UsuarioModel Atualizar(UsuarioModel usuarioModel);
        void Remover(UsuarioModel usuarioModel);
        void CriarADM();
        
        UsuarioModel BuscarUsuario(int id);
        
        UsuarioModel BuscarUsuarioPorEmail(string email);
    }
}
