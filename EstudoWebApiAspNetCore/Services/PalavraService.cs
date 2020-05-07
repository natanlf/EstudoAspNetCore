using EstudoWebApiAspNetCore.Models;
using EstudoWebApiAspNetCore.Repositories.Interfaces;
using EstudoWebApiAspNetCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNetCore.Services
{
    public class PalavraService: IPalavraService
    {
        private readonly IPalavraRepository _repository;
        public PalavraService(IPalavraRepository repository)
        {
            _repository = repository;
        }

        public void Atualizar(int id, Palavra palavra)
        {
            var obj = _repository.Obter(id);
            if (obj != null && palavra != null) {
                palavra.Id = id;
                palavra.Ativo = obj.Ativo;
                palavra.Criado = obj.Criado;
                palavra.Atualizado = DateTime.Now;
                _repository.Atualizar(palavra);
            }

        }

        public void Cadastrar(Palavra palavra)
        {
            if (palavra != null) {
                _repository.Cadastrar(palavra);
            }   
        }

        public void Deletar(int id)
        {
            _repository.Deletar(id);
        }

        public Palavra Obter(int id)
        {
            return _repository.Obter(id);
        }

        public List<Palavra> Todas()
        {
            return _repository.Todas();
        }
    }
}
