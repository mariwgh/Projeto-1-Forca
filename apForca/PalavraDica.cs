using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apListaLigada
{
    public class PalavraDica : IComparable<PalavraDica>, IRegistro,
                      ICriterioDeSeparacao<PalavraDica>
    {
        // atributos da classe PalavraDica:
        string palavra, dica;
        private const int tamanhoMaximo = 30;

        public string Palavra
        {
            get => palavra;
            set
            {
                if (value != "")
                    palavra = value.PadRight(tamanhoMaximo, ' ').Substring(0, tamanhoMaximo);
                else
                    throw new Exception("Palavra vazia é inválido.");
            }
        }
        public string Dica
        {
            get => dica;
            set
            {
                if (value != null)
                    dica = value;
                else
                    throw new Exception("Dica vazia é inválido.");
            }
        }

        public PalavraDica(string palavra, string dica)
        {
            if (palavra.Length > tamanhoMaximo)
            {
                throw new Exception("30 caracteres atingidos.");
            }

            Palavra = palavra;
            Dica = dica;
        }

        public PalavraDica(string linhaDeDados)
        {
            Palavra = linhaDeDados.PadRight(tamanhoMaximo, ' ').Substring(0, tamanhoMaximo);
            
            if (linhaDeDados.Length > tamanhoMaximo)
            {
                Dica = linhaDeDados.Substring(tamanhoMaximo).Trim();
            }
            else
            {
                Dica = "";
            }
        }


        public int CompareTo(PalavraDica other)
        {
            return this.palavra.CompareTo(other.palavra);
        }

        public bool DeveSeparar()
        {
            throw new NotImplementedException();
        }

        public string FormatoDeArquivo()
        {
            return $"{palavra}{dica}";
        }

        public override string ToString()
        {
            return palavra + " " + dica;
        }
    }
}
