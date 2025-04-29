using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aluno : IComparable<Aluno>, IRegistro, 
                      ICriterioDeSeparacao<Aluno>
{
  // mapeamento dos campos da linha de dados do arquivo (registro de Aluno)
  const int tamanhoRA = 5;
  const int tamanhoNome = 30;
  const int tamanhoNota = 4;
  const int inicioRA = 0;
  const int inicioNome = inicioRA + tamanhoRA;
  const int inicioNota = inicioNome + tamanhoNome;

  // atributos da classe Aluno:
  string ra, nome;
  float  nota;

  public bool DeveSeparar()
  {
    int raInteiro = Convert.ToInt32(ra);
    return raInteiro % 2 == 0;            // se for par, retorna true
  }

  public string RA    // propriedade 
  {
    get => ra;
    set
    {
      if (value != "")
         ra = value.PadLeft(tamanhoRA, '0').Substring(0, tamanhoRA);
      else
        throw new Exception("RA vazio é inválido.");
    }
  }

  public string Nome 
  { 
    get => nome;
    set
    {
      if (value != "")
        nome = value.PadRight(tamanhoNome, ' ').Substring(0, tamanhoNome);
      else
        throw new Exception("Nome vazio é inválido.");
    }
  }
  public float Nota 
  { 
    get => nota;
    set
    {
      if (value >= 0 && value <= 10)
         nota = value;
      else
        throw new Exception("Nota inválida.");
    }
  }

  public Aluno(string linhaDeDados)
  {
    RA = linhaDeDados.Substring(inicioRA, tamanhoRA);
    Nome = linhaDeDados.Substring(inicioNome, tamanhoNome);
    Nota = float.Parse(linhaDeDados.Substring(inicioNota));
  }
  public Aluno(string ra, string nome, float nota)
  {
    RA = ra;
    Nome = nome;
    Nota = nota;
  }

  public int CompareTo(Aluno outroAluno)
  {
    return this.ra.CompareTo(outroAluno.ra);
  }
  public override string ToString()
  {
    return ra + " " + nome + " " + nota;
  }

  public string FormatoDeArquivo()
  {
    return $"{ra}{nome}{nota:0.#}";
  }

}