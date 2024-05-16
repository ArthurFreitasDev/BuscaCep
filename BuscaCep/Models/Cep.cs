using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCep.Models
{
    public class Cep
    {
        public string CEP { get; set; }
        public string idLogradouro { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string idCidade { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
        public string DescricaoSemNumero { get; set; }
        public string DescricaoCidade {  get; set; }
        public string CodigoCidadeIBGE { get; set; }
        public string DescricaoBairro { get; set; }
    }
}