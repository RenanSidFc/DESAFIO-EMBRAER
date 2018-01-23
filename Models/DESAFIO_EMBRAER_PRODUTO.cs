using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DesafioEmbraer.Models
{   [Table("DESAFIO_EMBRAER_PRODUTOS")]
    public class DESAFIO_EMBRAER_PRODUTO
    {[Key]
        public int Produtoid { get; set; }
        public string Nome_prod { get; set; }
        public int Cod_prod { get; set; }
        public int Preco_prod { get; set; }
        
        
        public virtual DESAFIO_EMBRAER_VENDA DESAFIO_EMBRAER_VENDA { get; set; }
    }
}