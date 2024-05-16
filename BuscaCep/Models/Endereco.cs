using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCep.Models
{
    public class Endereco
    {
        public int idLogradouro { get; set; }
        public int idCidade { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string uf { get; set; }
        public string Complemento { get; set; }
        public string DescricaoSemNumero { get; set; }
        public string DescricaoCidade { get; set; }
        public string CodigoCidadeIBGE { get; set; }
        public string DescricaoBairro { get; set; }
        public object Rows { get; set; }
        public int CEP { get; set; }
        public int UF { get; set; }
    }
}
