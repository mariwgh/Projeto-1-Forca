using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace apListaLigada
{
  public partial class FrmAlunos : Form
  {
    ListaDupla<Aluno> lista1;

    public FrmAlunos()
    {
      InitializeComponent();
    }

    private void btnLerArquivo1_Click(object sender, EventArgs e)
    {

    }

    private void FazerLeitura(ref ListaDupla<Aluno> qualLista)
    {
      // instanciar a lista de palavras e dicas
      // pedir ao usuário o nome do arquivo de entrada
      // abrir esse arquivo e lê-lo linha a linha
      // para cada linha, criar um objeto da classe de Palavra e Dica
      // e inseri-0lo no final da lista duplamente ligada
    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
      // se o usuário digitou palavra e dica:
      // criar objeto da classe Palavra e Dica para busca
      // tentar incluir em ordem esse objeto na lista1
      // se não incluiu (já existe) avisar o usuário
    }


    private void btnBuscar_Click(object sender, EventArgs e)
    {
      // se a palavra digitada não é vazia:
      // criar um objeto da classe de Palavra e Dica para busca
      // se a palavra existe na lista1, posicionar o ponteiro atual nesse nó e exibir o registro atual
      // senão, avisar usuário que a palavra não existe
      // exibir o nó atual
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      // para o nó atualmente visitado e exibido na tela:
      // perguntar ao usuário se realmente deseja excluir essa palavra e dica
      // se sim, remover o nó atual da lista duplamente ligada e exibir o próximo nó
      // se não, manter como está
    }

    private void FrmAlunos_FormClosing(object sender, FormClosingEventArgs e)
    {
      // solicitar ao usuário que escolha o arquivo de saída
      // percorrer a lista ligada e gravar seus dados no arquivo de saída
    }

    private void ExibirDados(ListaDupla<Aluno> aLista, ListBox lsb, Direcao qualDirecao)
    {
      lsb.Items.Clear();
      var dadosDaLista = aLista.Listagem(qualDirecao);
      foreach (Aluno aluno in dadosDaLista)
        lsb.Items.Add(aluno);
    }

    private void tabControl1_Enter(object sender, EventArgs e)
    {
      rbFrente.PerformClick();
    }

    private void rbFrente_Click(object sender, EventArgs e)
    {
      ExibirDados(lista1, lsbDados, Direcao.paraFrente);
    }

    private void rbTras_Click(object sender, EventArgs e)
    {
      ExibirDados(lista1, lsbDados, Direcao.paraTras);
    }

    private void FrmAlunos_Load(object sender, EventArgs e)
    {
      // fazer a leitura do arquivo escolhido pelo usuário e armazená-lo na lista1
      // posicionar o ponteiro atual no início da lista duplamente ligada
      // Exibir o Registro Atual;
    }

    private void btnInicio_Click(object sender, EventArgs e)
    {
      // posicionar o ponteiro atual no início da lista duplamente ligada
      // Exibir o Registro Atual;
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
      // Retroceder o ponteiro atual para o nó imediatamente anterior 
      // Exibir o Registro Atual;
    }

    private void btnProximo_Click(object sender, EventArgs e)
    {
      // Retroceder o ponteiro atual para o nó seguinte 
      // Exibir o Registro Atual;
    }

    private void btnFim_Click(object sender, EventArgs e)
    {
      // posicionar o ponteiro atual no último nó da lista 
      // Exibir o Registro Atual;
    }

    private void ExibirRegistroAtual()
    {
      // se a lista não está vazia:
      // acessar o nó atual e exibir seus campos em txtDica e txtPalavra
      // atualizar no status bar o número do registro atual / quantos nós na lista
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      // alterar a dica e guardar seu novo valor no nó exibido
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {

    }
  }
}
