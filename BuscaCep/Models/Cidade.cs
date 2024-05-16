using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCep.Models
{
    public class Cidade
    {
        public int idCidade { get; set; }
        public string Descricao { get; set; }
        public string UF { get; set; }
        public int CodigoIBGE { get; set; }
        public int DDD { get; set; }
    }
}
