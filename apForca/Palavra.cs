using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apListaLigada
{
    internal class Palavra : IComparable<Palavra>, IRegistro,
                      ICriterioDeSeparacao<Palavra>
    {
        public int CompareTo(Palavra other)
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

        //private string palavraLista;
        public string PalavraLista{ get; set; }
        int tamanhoMaximo = 30;

        public Palavra(string palavraLista)
        {
            //creio que não precisa, mas ja foi
            if (palavraLista.Length <= 30)
                PalavraLista = palavraLista;

            else
                throw new Exception("Tamanho máximo de palavra excedido!");
        }
    }
}
