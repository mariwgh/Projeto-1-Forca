using System;
using System.Collections.Generic;
using System.IO;

public enum Direcao { paraFrente, paraTras };

public class ListaDupla<Dado> 
             where Dado : IComparable<Dado>, IRegistro
{
  NoDuplo<Dado> primeiro, ultimo, 
                atual;   // é usado para percorrer a lista e mostrar
                         // o nó que está sendo visitado a cada momento
  int quantosNos;
  bool primeiroAcessoDoPercurso;
  int numeroDoNoAtual;    // "índice" do nó apontado por atual

  public void PosicionarNoInicio()
  {
    //  codificar
  }

  public void PosicionarNoFinal()
  {
    //  codificar
  }

  public void Avancar()
  {
    //  codificar
  }

  public void Retroceder()
  {
    //  codificar
  }

  public void PosicionarEm(int indice)
  {
    // fica para vocês fazerem

    // verificar se indice é válido ( >= 0 && < quantosNos)
    // se for valido:
    //    atual aponta o primeiro nó;
    //    percorre "indice" nós com o ponteiro atual sequencial
    //      atualiza a variável numeroDoNoAtual
  }

  public Dado this[int indice]
  {
    get
    {
      PosicionarEm(indice);
      return atual.Info;
    }
    set
    {
      PosicionarEm(indice);
      atual.Info = value;
    }
  }

  public List<Dado> Listagem(Direcao qualDirecao)
  {
    var dados = new List<Dado>();
    if (qualDirecao == Direcao.paraFrente)
    {
      atual = primeiro;     // posiciona ponteiro de percurso no 1o nó
      while (atual != null) // enquanto houver nós a visitar
      {
        dados.Add(atual.Info);  // inclui no listbox os dados do nó visitado agora
        atual = atual.Prox;     // avança o ponteiro de percurso para o nó seguinte
      }
    }
    else
    {
      atual = ultimo;       // posiciona ponteiro de percurso no último nó
      while (atual != null) // enquanto houver nós a visitar
      {
        dados.Add(atual.Info);  // inclui no listbox os dados do nó visitado agora
        atual = atual.Ant;      // retrocede o ponteiro de percurso para o nó anterior
      }
    }
    return dados;
  }

  public ListaDupla()
  {
    primeiro = ultimo = atual = null;
    quantosNos = numeroDoNoAtual = 0;
    primeiroAcessoDoPercurso = false;
  }

  public bool EstaVazia
  {
    get => primeiro == null;
  }
  public NoDuplo<Dado> Primeiro
  {
    get => primeiro;
  }
  public NoDuplo<Dado> Ultimo
  {
    get => ultimo;
  }
  public int QuantosNos
  {
    get => quantosNos;
  }

  public void InserirAntesDoInicio(Dado novoDado)
  {
    var novoNo = new NoDuplo<Dado>(novoDado);

    if (EstaVazia)
       ultimo = novoNo;

    novoNo.Prox = primeiro;
    primeiro    = novoNo;
    quantosNos++;
  }

  public void InserirAposFim(Dado novoDado)
  {
    var novoNo = new NoDuplo<Dado>(novoDado);

    if (EstaVazia)
      primeiro = novoNo;
    else
      ultimo.Prox = novoNo;

    ultimo = novoNo;
    quantosNos++;
  }

  public void InserirAposFim(NoDuplo<Dado> noExistente)
  {
    if (noExistente != null)
    {
      if (EstaVazia)
        primeiro = noExistente;
      else
        ultimo.Prox = noExistente;

      ultimo = noExistente;
      noExistente.Prox = null;
      quantosNos++;
    }
  }

  public bool Existe(Dado outroProcurado)
  {
    //anterior = null;
    atual = primeiro;

    //	Em seguida, é verificado se a lista está vazia. Caso esteja, é
    //	retornado false ao local de chamada, indicando que a chave não foi
    //	encontrada, e atual e anterior ficam valendo null
    if (EstaVazia)
       return false;
 
    // a lista não está vazia, possui nós
    // dado procurado é menor que o primeiro dado da lista:
    // portanto, dado procurado não existe
    if (outroProcurado.CompareTo(primeiro.Info) < 0)
       return false;

    // dado procurado é maior que o último dado da lista:
    // portanto, dado procurado não existe
    if (outroProcurado.CompareTo(ultimo.Info) > 0)
    {
      // anterior = ultimo;
      atual = null;
      return false;
    }

    //	caso não tenha sido definido que a chave está fora dos limites de 
    //	chaves da lista, vamos procurar no seu interior
    //	o apontador atual indica o primeiro nó da lista e consideraremos que
    //	ainda não achou a chave procurada nem chegamos ao final da lista
    bool achou = false;
    bool fim = false;

    //	repete os comandos abaixo enquanto não achou o RA nem chegou ao
    //	final da pesquisa
    while (!achou && !fim)
      // se o apontador atual vale null, indica final físico da lista
      if (atual == null)
         fim = true;
      // se não chegou ao final da lista, verifica o valor da chave atual
      else
        // verifica igualdade entre chave procurada e chave do nó atual
        if (outroProcurado.CompareTo(atual.Info) == 0)
           achou = true;
        else
          // se chave atual é maior que a procurada, significa que
          // a chave procurada não existe na lista ordenada e, assim,
          // termina a pesquisa indicando que não achou. Anterior
          // aponta o nó anterior ao atual, que foi acessado na
          // última repetição
          if (atual.Info.CompareTo(outroProcurado) > 0)
             fim = true;
          else
          {
            // se não achou a chave procurada nem uma chave > que ela,
            // então a pesquisa continua, de maneira que o apontador
            // anterior deve apontar o nó atual e o apontador atual
            // deve seguir para o nó seguinte
        //    anterior = atual;
            atual = atual.Prox;
          }

    // por fim, caso a pesquisa tenha terminado, o apontador atual
    // aponta o nó onde está a chave procurada, caso ela tenha sido
    // encontrada, ou aponta o nó onde ela deveria estar para manter a
    // ordenação da lista. O apontador anterior aponta o nó anterior
    // ao atual
    return achou;   // devolve o valor da variável achou, que indica
  }

  public NoDuplo<Dado> Atual => atual;

  public int NumeroDoNoAtual { get => numeroDoNoAtual; set => numeroDoNoAtual = value; }

  public bool InserirEmOrdem(Dado dados)
  {
    if (Existe(dados))     // Existe() configura anterior e atual
      return false;
    
    // aqui temos certeza de que a chave não existe
    // guardaremos os dados no novo nó
    if (EstaVazia)                  // se a lista está vazia, então o 	
      InserirAntesDoInicio(dados);  // dado ficará como primeiro da lista
    else
        // testa se nova chave < primeira chave
        if (/*anterior == null && */ atual != null)
          InserirAntesDoInicio(dados); // liga novo nó antes do primeiro
        else
          // testa se nova chave > última chave
          if (/*anterior != null && */ atual == null)
            InserirAposFim(dados);
          else
            InserirNoMeio(dados);  // insere entre os nós anterior e atual
      
    return true;  // conseguiu incluir pois não é repetido
  }

  private void InserirNoMeio(Dado dados)
  {
    // Existe() encontrou intervalo de inclusão do novo nó (entre anterior e atual)

    var novo = new NoDuplo<Dado>(dados);
    anterior.Prox = novo;   // liga anterior ao novo
    novo.Prox = atual;      // e novo no atual

    if (anterior == ultimo)  // se incluiu ao final da lista,
       ultimo = novo;        // atualiza o apontador ultimo
    quantosNos++;            // incrementa número de nós da lista     	}	
  }

  public bool Remover(Dado dadoARemover)
  {
    if (EstaVazia)
      return false;

    if (!Existe(dadoARemover))
      return false;

    // aqui sabemos que o nó foi encontrado e o método
    // Existe() configurou os ponteiros atual e anterior
    // para delimitar onde está o nó a ser removido

    if (atual == primeiro)
    {
      primeiro = primeiro.Prox;
      if (primeiro == null)  // removemos o único nó da lista
        ultimo = null;
    }
    else
      if (atual == ultimo)
      {
        anterior.Prox = null;   // desliga o último nó
        ultimo = anterior;
      }
      else     // nó interno a ser excluido
      {
        anterior.Prox = atual.Prox;
      }

    quantosNos--;
    return true;
  }

  public void GravarDados(string nomeArq)
  {
    var arquivo = new StreamWriter(nomeArq);
    atual = primeiro;
    while (atual != null) 
    {
      arquivo.WriteLine(atual.Info.FormatoDeArquivo());
      atual = atual.Prox;
    }
    arquivo.Close();
  }

}
