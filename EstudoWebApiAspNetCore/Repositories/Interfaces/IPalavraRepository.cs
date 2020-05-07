using EstudoWebApiAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNetCore.Repositories.Interfaces
{
    public interface IPalavraRepository
    {
        Palavra Obter(int id);
        void Cadastrar(Palavra palavra);
        void Atualizar(Palavra palavra);
        void Deletar(int id);
        List<Palavra> Todas();
        List<Palavra> TodasPaginacao(DateTime data, int pagNumero, int pagRegistroPag);
    }
}
