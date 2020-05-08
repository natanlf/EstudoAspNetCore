using AutoMapper;
using EstudoWebApiAspNetCore.Models;
using EstudoWebApiAspNetCore.Models.DTO;
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
        private readonly IMapper _mapper;
        public PalavraService(IPalavraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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

        public PalavraDTO Obter(int id)
        {

            var obj = _repository.Obter(id);

            PalavraDTO palavraDTO = _mapper.Map<Palavra, PalavraDTO>(obj);
            palavraDTO.Links = new List<LinkDTO>();
            palavraDTO.Links.Add(
                new LinkDTO("self", $"https://localhost:44337/api/palavras/{palavraDTO.Id}", "GET")
            );

            return palavraDTO;
        }

        public List<Palavra> Todas()
        {
            return _repository.Todas();
        }

        List<Palavra> IPalavraService.TodasPaginacao(DateTime data, int pagNumero, int pagRegistroPag)
        {
            return _repository.TodasPaginacao(data, pagNumero, pagRegistroPag);
        }
    }
}
