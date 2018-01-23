using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DesafioEmbraer.Models;

namespace DesafioEmbraer.DAL
{
    public class LojaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LojaContext>
    {
        protected override void Seed(LojaContext context)
        {
            var desafio_embraer_produtos = new List<DESAFIO_EMBRAER_PRODUTO>
            {
            new DESAFIO_EMBRAER_PRODUTO{Nome_prod="Teclado",Cod_prod=1234551,Preco_prod=49},
            new DESAFIO_EMBRAER_PRODUTO{Nome_prod="Mouse",Cod_prod=1234523,Preco_prod=12},
            new DESAFIO_EMBRAER_PRODUTO{Nome_prod="Monitor",Cod_prod=1234512,Preco_prod=499},
            new DESAFIO_EMBRAER_PRODUTO{Nome_prod="Notebook",Cod_prod=123423,Preco_prod=2099},
            new DESAFIO_EMBRAER_PRODUTO{Nome_prod="Headphone",Cod_prod=1234981,Preco_prod=129},
            new DESAFIO_EMBRAER_PRODUTO{Nome_prod="Hd externo",Cod_prod=1234111,Preco_prod=300},
            
            };

            desafio_embraer_produtos.ForEach(s => context.DESAFIO_EMBRAER_PRODUTOS.Add(s));
            context.SaveChanges();

            var desafio_embraer_vendas= new List<DESAFIO_EMBRAER_VENDA>
            {
               
            new DESAFIO_EMBRAER_VENDA{Cod_prod=1234551,Vendedor="Nino",Valor_unit=129,Quantidade=1,Valor_total= 9,Data=DateTime.Parse("2018-01-09")},
            new DESAFIO_EMBRAER_VENDA{Cod_prod=1234523,Vendedor="Paulo",Valor_unit=3,Quantidade=3,Valor_total= 9,Data=DateTime.Parse("2018-01-03")},
            new DESAFIO_EMBRAER_VENDA{Cod_prod=1234321,Vendedor="Jorge",Valor_unit=2,Quantidade=3,Valor_total= 6,Data=DateTime.Parse("2018-09-01")},
            new DESAFIO_EMBRAER_VENDA{Cod_prod=1234344,Vendedor="João",Valor_unit=2000,Quantidade=1,Valor_total= 2000,Data=DateTime.Parse("2018-03-01")},
            new DESAFIO_EMBRAER_VENDA{Cod_prod=1234123,Vendedor="Pedro",Valor_unit=7,Quantidade=3,Valor_total= 21,Data=DateTime.Parse("2018-03-02")},
            new DESAFIO_EMBRAER_VENDA{Cod_prod=1234513,Vendedor="Lucas",Valor_unit=12,Quantidade=3,Valor_total= 36,Data=DateTime.Parse("2018-07-01")},
           
            };
            desafio_embraer_vendas.ForEach(s => context.DESAFIO_EMBRAER_VENDAS.Add(s));
            context.SaveChanges();
            
        }
    }
}