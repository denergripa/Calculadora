using CadastrandoProdutos.Builder.Domain.Produtos.Origens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrandoProdutos.Builder.Domain.Produtos
{
    public class ProdutoBuilder
    {
        private int Codigo { get; set; }
        private Guid IdExterno { get; set; }
        private string Nome { get; set; }
        private decimal SaldoEmEstoque { get; set; }
        private Origem Origem { get; set; }
        private DateTime? DataDeImportacao { get; set; }
        private int? NumeroDaNotaFiscalDeImportacao { get; set; }
        private int? IdDoAplicativoExterno { get; set; }


        public Produto Build() {
            return new Produto(Codigo, Nome, SaldoEmEstoque,
                Origem, DataDeImportacao, NumeroDaNotaFiscalDeImportacao, IdDoAplicativoExterno);
        } 
        public ProdutoBuilder WithCodigo(int codigo) {
            Codigo = codigo;
            return this;
        }

        public ProdutoBuilder WithIdExterno(Guid idExterno) {
            IdExterno = IdExterno;
            return this;
        }

        public ProdutoBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ProdutoBuilder WithSaldoEmEstoque(decimal saldoEmEstoque)
        {
            SaldoEmEstoque = saldoEmEstoque;
            return this;
        }

        public ProdutoBuilder WithOrigem(Origem origem)
        {
            Origem = origem;
            return this;
        }

        public ProdutoBuilder WithDataDeImportacao(DateTime? dataDeImportacao)
        {
            DataDeImportacao = dataDeImportacao;
            return this;
        }

        public ProdutoBuilder WithNumeroDaNotaFiscalDeImportacao(int numeroDaNotaFiscalDeImportacao)
        {
            NumeroDaNotaFiscalDeImportacao = numeroDaNotaFiscalDeImportacao;
            return this;
        }

        public ProdutoBuilder WithIdDoAplicativoExterno(int idDoAplicativoExterno)
        {
            IdDoAplicativoExterno = idDoAplicativoExterno;
            return this;
        }

    }
}