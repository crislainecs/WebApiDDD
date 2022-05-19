using PrimeiraWebApi.Application.DTO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraWebApi.Application.Interfaces
{
    public interface IProdutoAppService
    {
        IEnumerable<ProdutoDTO> GetAll();

        ProdutoDTO Insert(ProdutoDTO produtoDTO);

        ProdutoDTO Update(ProdutoDTO produtoDTO);

        ProdutoDTO GetProdutoDTOById(int id);

        void Delete(int id);

            
    }
}
