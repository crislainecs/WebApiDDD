using PrimeiraWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraWebApi.Infra.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();

        Produto Insert(Produto produtoDTO);

        Produto Update(Produto produtoDTO);

        Produto GetById(int id);

        void Delete(Produto produto);
    }
}