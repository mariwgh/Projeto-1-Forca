using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace apListaLigada
{
    public partial class FrmAlunos : Form
    {
        ListaDupla<Aluno> lista1;

        string caminho = null;

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
            ListaDupla<PalavraDica> listaPalavraDica = new ListaDupla<PalavraDica>();

            // pedir ao usuário o nome do arquivo de entrada
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione um arquivo:";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                caminho = ofd.FileName;
            }

            // abrir esse arquivo e lê-lo linha a linha
            string linha = "";
            StreamReader arquivo = new StreamReader(caminho);
            while (!arquivo.EndOfStream)
            {
                linha = arquivo.ReadLine();

                // para cada linha, criar um objeto da classe de Palavra e Dica
                PalavraDica palavraDica = new PalavraDica(linha);

                // e inseri-lo no final da lista duplamente ligada
                listaPalavraDica.InserirAposFim(palavraDica);
            }

            arquivo.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // se o usuário digitou palavra e dica:
            if (txtPalavra.Text != "" && txtDica.Text != "")
            {
                // criar objeto da classe Palavra e Dica para busca
                PalavraDica palavraDica = new PalavraDica(txtPalavra.Text, txtDica.Text);

                // tentar incluir em ordem esse objeto na lista1
                try
                {
                    lista1.InserirEmOrdem(palavraDica);
                }
                
                // se não incluiu (já existe) avisar o usuário
                catch
                {
                    MessageBox.Show("Já existe.");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // se a palavra digitada não é vazia:
            if (txtPalavra.Text != "")
            {
                Palavra objPalavra = new Palavra(txtPalavra.Text);
                Dica objDica = new Dica(txtDica.Text);
                Aluno word = new Aluno(txtPalavra.Text);
                if (lista1.Existe(word))
                {
                    lista1.PosicionarEm(lista1.NumeroDoNoAtual);
                    ExibirRegistroAtual();
                }
                else
                {
                    MessageBox.Show("A palavra não existe na lista.");
                }
                ExibirRegistroAtual();  //registro ou nó??? que???? não entendi
            }
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
            if (txtPalavra.Text != "")
            {
                if (lista1.Remover(new Aluno(txtPalavra.Text, "-", 0)))
                {
                    MessageBox.Show("Aluno(a) removido(a).");
                    ExibirRegistroAtual();
                }
                else
                    MessageBox.Show("Aluno(a) não encontrado(a).");
            }
        }

        private void FrmAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            string caminhoSaida = null;
            // solicitar ao usuário que escolha o arquivo de saída
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione um arquivo de saída:";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoSaida = openFileDialog.FileName;
            }
            // percorrer a lista ligada e gravar seus dados no arquivo de saída
            StreamWriter escritor = new StreamWriter(caminhoSaida);
            Aluno dadoAtual = lista1.Atual.Info;
            while (dadoAtual != null)
            {
                escritor.WriteLine(dadoAtual.ToString());
                lista1.Avancar();
            }

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
            StreamReader sr = new StreamReader(caminho);
            string linha = "";
            while (linha != null)
            {
                linha = sr.ReadLine();
                Aluno objAluno = new Aluno(linha);
                lista1.InserirAntesDoInicio(objAluno);      //pode ser outro inserir, marietti?? bjs te amo
            }

            // posicionar o ponteiro atual no início da lista duplamente ligada
            lista1.PosicionarNoInicio();
            // Exibir o Registro Atual;
            ExibirRegistroAtual();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // posicionar o ponteiro atual no início da lista duplamente ligada
            lista1.PosicionarNoInicio();
            // Exibir o Registro Atual;
            ExibirRegistroAtual();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Retroceder o ponteiro atual para o nó imediatamente anterior 
            lista1.Retroceder();
            // Exibir o Registro Atual;
            ExibirRegistroAtual();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            // Retroceder o ponteiro atual para o nó seguinte 
            lista1.Avancar();
            //ou lista1.Retroceder(); ????????????????????
            // Exibir o Registro Atual;
            ExibirRegistroAtual();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            // posicionar o ponteiro atual no último nó da lista 
            lista1.Atual = lista1.Ultimo;
            // Exibir o Registro Atual;
            ExibirRegistroAtual();
        }

        private void ExibirRegistroAtual()
        {
            // se a lista não está vazia:
            // acessar o nó atual e exibir seus campos em txtDica e txtPalavra
            // atualizar no status bar o número do registro atual / quantos nós na lista
            if (!lista1.EstaVazia)
            {
                var alunoAtual = lista1[lista1.NumeroDoNoAtual];
                txtRA.Text = alunoAtual.RA;
                txtNome.Text = alunoAtual.Nome;
                udNota.Value = (decimal)alunoAtual.Nota;
                slRegistro.Text = $"Registro: {lista1.NumeroDoNoAtual + 1}/{lista1.QuantosNos}";
            }
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

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
