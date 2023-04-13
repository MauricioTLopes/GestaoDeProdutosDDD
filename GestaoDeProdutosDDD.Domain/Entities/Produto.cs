using System;
using System.Collections.Generic;
using System.Linq;
namespace GestaoDeProdutosDDD.Domain.Entities
{
    public class Produto : Base
    {
        public string Descricao { get; set; }
        public bool Situacao { get; set;}
        public DateTime DataFabricacao { get; set;}
        public DateTime DataValidade { get; set; }
        public int CodigoFornecedor { get; set; }
        public string DescricaoFornecedor { get; set; }
        public string CNPJFornecedor { get; set; }

    }
}
