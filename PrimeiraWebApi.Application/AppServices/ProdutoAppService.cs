using PrimeiraWebApi.Application.DTO;
using PrimeiraWebApi.Application.Interfaces;
using PrimeiraWebApi.Domain.Entities;
using PrimeiraWebApi.Infra.Interfaces;

namespace PrimeiraWebApi.Application.AppServices
{
    public class ProdutoAppService : IProdutoAppService
    {
       private readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Delete(int id)
        {
            var produto = _produtoRepository.GetById(id);
            _produtoRepository.Delete(produto);
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = _produtoRepository.GetAll();
            var produtosDTO = produtos.Select(c => new ProdutoDTO
            {
                Id = c.Id,
                Marca = c.Marca,
                Nome = c.Nome
            });
            return produtosDTO;
        }

        public ProdutoDTO GetProdutoDTOById(int id)
        {
            var produto = _produtoRepository.GetById(id);

            var produtoDTO = new ProdutoDTO
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Marca = produto.Marca
            };

            return produtoDTO;
        }

        public ProdutoDTO Insert(ProdutoDTO produtoDTO)
        {
            var produto = new Produto
            {
                Marca = produtoDTO.Marca,
                Nome = produtoDTO.Nome
            };

            _produtoRepository.Insert(produto);

            produtoDTO.Id = produto.Id;
            return produtoDTO;
        }


        public ProdutoDTO Update(ProdutoDTO produtoDTO)
        {
            var produtoAlterado = _produtoRepository.GetById((int)produtoDTO.Id);
            produtoAlterado.Nome = produtoDTO.Nome;
            produtoAlterado.Marca = produtoDTO.Marca;
            _produtoRepository.Update(produtoAlterado);
            return produtoDTO;
        }
        

    
    }
}