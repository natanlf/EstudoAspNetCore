using EstudoWebApiAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNetCore.Services.Interfaces
{
    public interface IPalavraService
    {
        Palavra Obter(int id);
        void Cadastrar(Palavra palavra);
        void Atualizar(Palavra palavra);
        void Deletar(int id);
        List<Palavra> Todas();
    }
}
