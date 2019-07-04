using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class InOperacoes
    {
        public List<InOperacao> Operacao { get; set; }
    }

    public class InOperacao
    {
        public string CodigoOperacao { get; set; }
        public double ValorOperacao { get; set; }
    }
}