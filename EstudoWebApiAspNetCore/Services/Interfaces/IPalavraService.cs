﻿using EstudoWebApiAspNetCore.Models;
using EstudoWebApiAspNetCore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNetCore.Services.Interfaces
{
    public interface IPalavraService
    {
        PalavraDTO Obter(int id);
        void Cadastrar(Palavra palavra);
        void Atualizar(int id, Palavra palavra);
        void Deletar(int id);
        List<Palavra> Todas();
        List<Palavra> TodasPaginacao(DateTime data, int pagNumero, int pagRegistroPag);
    }
}
