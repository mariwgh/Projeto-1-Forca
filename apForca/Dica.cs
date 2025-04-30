using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apListaLigada
{
    internal class Dica : IComparable<Dica>, IRegistro,
                      ICriterioDeSeparacao<Dica>
    {
        public int CompareTo(Dica other)
        {
            throw new NotImplementedException();
        }

        public bool DeveSeparar()
        {
            throw new NotImplementedException();
        }

        public string FormatoDeArquivo()
        {
            throw new NotImplementedException();
        }
        //oq q tem q fazer aqui?

        public string DicaPalavra { get; set; }

        public Dica(string sla)
        {
            DicaPalavra = sla;
        }
    }
}
