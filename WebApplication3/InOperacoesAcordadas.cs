using System.Collections.Generic;

namespace WebApplication3
{
    public class InOperacoesAcordadas
    {
        public List<OperacaoAcordada> Operacao { get; set; }
    }

    public class OperacaoAcordada
    {
        public string CodigoOperacao { get; set; }
        public double ValorOperacao { get; set; }
    }
}