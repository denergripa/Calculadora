﻿using CadastrandoProdutos.Builder.Domain.Produtos;
using CadastrandoProdutos.Builder.Domain.Produtos.Origens.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrandoProdutos.Builder.Services
{
    public class ProdutoServices : IProdutoServices
    {


        public Produto CriarProdutoOriginadoDaTelaDeCadastro(int codigo, string nome, decimal saldoEmEstoque)
        {
            var origem = new OrigemDoCadastro();
            // return new Produto(codigo, nome, saldoEmEstoque, origem, null, null);
            return new ProdutoBuilder()
                 .WithCodigo(codigo)
                 .WithNome(nome)
                 .WithOrigem(origem)
                 .WithSaldoEmEstoque(saldoEmEstoque)
                 .Build();
        }

        public Produto CriarProdutoOriginadoDaImportacaoDeProdutos(int codigo, string nome, decimal saldoEmEstoque, DateTime dataDaImportacao)
        {
            var origem = new OrigemDeImportacaoDeProdutos();
            // return new Produto(codigo, nome, saldoEmEstoque, origem, dataDaImportacao, null);
            return new ProdutoBuilder()
                 .WithCodigo(codigo)
                 .WithNome(nome)
                 .WithOrigem(origem)
                 .WithSaldoEmEstoque(saldoEmEstoque)
                 .WithDataDeImportacao(dataDaImportacao)
                 .Build();
        }

        public Produto CriarProdutoOriginadoDeNotaFiscalDeEntrada(int codigo, string nome, decimal saldoEmEstoque, DateTime dataDaImportacao, int numeroDaNotaDeEntrada)
        {
            var origem = new OrigemDeNotaFiscalDeEntrada();
            //return new Produto(codigo, nome, saldoEmEstoque, origem, dataDaImportacao, numeroDaNotaDeEntrada);
            return new ProdutoBuilder()
                .WithCodigo(codigo)
                .WithNome(nome)
                .WithOrigem(origem)
                .WithSaldoEmEstoque(saldoEmEstoque)
                .WithDataDeImportacao(dataDaImportacao)
                .WithNumeroDaNotaFiscalDeImportacao(numeroDaNotaDeEntrada)
                .Build();
        }
    }
}