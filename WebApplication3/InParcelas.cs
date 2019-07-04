

using System.Collections.ObjectModel;

namespace WebApplication3
{
    public class InParcelas
    {
        Collection<InParcela> Parcela { get; set; }
    }

    public class InParcela
    {
        public int NrParcela { get; set; }
        public int ValorParcela { get; set; }
    }
}