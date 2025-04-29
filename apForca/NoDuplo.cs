using System;

public class NoDuplo<Dado> where Dado : IComparable<Dado>, IRegistro                                      
{
  NoDuplo<Dado> ant;
  Dado info;
  NoDuplo<Dado> prox;

  public NoDuplo(NoDuplo<Dado> anterior, Dado novaInfo, NoDuplo<Dado> proximo)
  {
    Ant = anterior;
    Info = novaInfo;
    Prox = proximo;
  }

  public NoDuplo(Dado novaInfo) : this(null, novaInfo, null) { }

  public NoDuplo<Dado> Ant
  {
    get => ant;
    set => ant = value;
  }

  public Dado Info
  {
    get => info;
    set
    {
      if (value != null)
        info = value;
    }
  }

  public NoDuplo<Dado> Prox
  {
    get => prox;
    set => prox = value;
  }

}

