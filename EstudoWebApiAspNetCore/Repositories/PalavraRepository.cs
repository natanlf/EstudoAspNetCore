using EstudoWebApiAspNetCore.Database;
using EstudoWebApiAspNetCore.Models;
using EstudoWebApiAspNetCore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNetCore.Repositories
{
    public class PalavraRepository : IPalavraRepository
    {
        private readonly MimicContext _banco;

        public PalavraRepository(MimicContext banco)
        {
            _banco = banco;
        }
        public void Atualizar(Palavra palavra)
        {
            _banco.Palavras.Update(palavra);
            _banco.SaveChanges();
        }

        public void Cadastrar(Palavra palavra)
        {
            _banco.Palavras.Add(palavra);
            _banco.SaveChanges();
        }

        public void Deletar(int id)
        {
            var palavra = Obter(id);
            palavra.Ativo = false;
            _banco.Palavras.Update(palavra);
            _banco.SaveChanges();
        }

        public Palavra Obter(int id)
        {
            var item = _banco.Palavras.AsNoTracking().AsQueryable();
            if (item.Count() > 0)
            {
                return _banco.Palavras.AsNoTracking().FirstOrDefault(a => a.Id == id);
            }
            else {
                return null;
            }
            
        }

        public List<Palavra> Todas() {
            List<Palavra> palavras = new List<Palavra>();
            var itens = _banco.Palavras.Count() > 0 ? _banco.Palavras.ToList() : null;
            if (itens == null) {
                return null;
            }
            return itens;
        }
    }
}
