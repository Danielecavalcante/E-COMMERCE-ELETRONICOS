﻿using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IntefaceProduct
{
    public interface IProduct : IGeneric<Produto>
    {
        Task<List<Produto>> ListarProdutosUsuario(string userId);

        Task<List<Produto>> ListarProdutos(Expression<Func<Produto, bool>> exProduto);

        Task<List<Produto>> ListarProdutosCarrinhoUsuario(string userId);

        Task<Produto> ObterProdutoCarrinho(int idProdutoCarrinho);

        Task<List<Produto>> ListarProdutosVendidos(string userId, string filtro);
    }
}
