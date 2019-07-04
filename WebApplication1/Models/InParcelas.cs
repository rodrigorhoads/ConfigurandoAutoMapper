using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class InParcelas
    {
        public List<InParcela> Parcela { get; set; }
    }


    public class InParcela
    {
        public int NrParcela { get; set; }
        public int ValorParcela { get; set; }
    }
}