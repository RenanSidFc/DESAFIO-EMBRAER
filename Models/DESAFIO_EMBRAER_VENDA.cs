using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioEmbraer.Models
{
    [Table("DESAFIO_EMBRAER_VENDAS")]
    public class DESAFIO_EMBRAER_VENDA
    {   [Key]
        public int Vendaid { get; set; }
        
        public int Cod_prod { get; set; }
        public string Vendedor { get; set; }
        public int Valor_unit { get; set; }
        public int Quantidade { get; set; }
        public int Valor_total { get; set; }
        public DateTime Data { get; set; }

        public  virtual ICollection<DESAFIO_EMBRAER_PRODUTO> DESAFIO_EMBRAER_PRODUTOS { get; set; }
    }
}