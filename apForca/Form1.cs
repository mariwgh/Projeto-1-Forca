using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace apListaLigada
{
    public partial class FrmAlunos : Form
    {
        ListaDupla<PalavraDica> lista1;

        string caminho = null;

        public FrmAlunos()
        {
            InitializeComponent();

        }

        private void btnLerArquivo1_Click(object sender, EventArgs e)
        {

        }

        private void FazerLeitura(ref ListaDupla<PalavraDica> qualLista)
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
                // criar um objeto da classe de Palavra e Dica para busca
                PalavraDica palavraDica = new PalavraDica(txtPalavra.Text, "-");

                // se a palavra existe na lista1, posicionar o ponteiro atual nesse nó e exibir o registro atual
                if (lista1.Existe(palavraDica))
                {
                    lista1.PosicionarEm(lista1.NumeroDoNoAtual);
                    ExibirRegistroAtual();
                }

                // senão, avisar usuário que a palavra não existe
                else
                {
                    MessageBox.Show("A palavra não existe.");
                }

                // exibir o nó atual
                ExibirRegistroAtual();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // para o nó atualmente visitado e exibido na tela:
            if (lista1.Atual != null)
            {
                NoDuplo<PalavraDica> noAtual = lista1.Atual;

                // perguntar ao usuário se realmente deseja excluir essa palavra e dica
                DialogResult resposta = MessageBox.Show($"Deseja realmente excluir a palavra '{noAtual.Info.Palavra}'?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // se sim, remover o nó atual da lista duplamente ligada e exibir o próximo nó
                if (resposta == DialogResult.Yes)
                {
                    lista1.Remover(noAtual.Info);
                }
            }

            // se não, manter como está
        }

        private void FrmAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            // solicitar ao usuário que escolha o arquivo de saída
            string caminhoSaida = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione um arquivo de saída: ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoSaida = openFileDialog.FileName;
            }

            // percorrer a lista ligada e gravar seus dados no arquivo de saída
            PalavraDica dadoAtual = lista1.Atual.Info;
            while (dadoAtual != null)
            {
                lista1.GravarDados(caminhoSaida);
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
            //ExibirDados(lista1, lsbDados, Direcao.paraFrente);
        }

        private void rbTras_Click(object sender, EventArgs e)
        {
            //ExibirDados(lista1, lsbDados, Direcao.paraTras);
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            // fazer a leitura do arquivo escolhido pelo usuário e armazená-lo na lista1
            FazerLeitura(ref lista1);

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

            // Exibir o Registro Atual;
            ExibirRegistroAtual();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            // posicionar o ponteiro atual no último nó da lista 
            lista1.PosicionarNoFinal();

            // Exibir o Registro Atual;
            ExibirRegistroAtual();
        }

        private void ExibirRegistroAtual()
        {
            // se a lista não está vazia:
            if (!lista1.EstaVazia)
            {
                // acessar o nó atual e exibir seus campos em txtDica e txtPalavra
                var noAtual = lista1[lista1.NumeroDoNoAtual];
                txtPalavra.Text = noAtual.Palavra;
                txtDica.Text = noAtual.Dica;

                // atualizar no status bar o número do registro atual / quantos nós na lista
                slRegistro.Text = $"Registro: {lista1.NumeroDoNoAtual + 1}/{lista1.QuantosNos}";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // alterar a dica e guardar seu novo valor no nó exibido
            if (!lista1.EstaVazia)
            {
                var registroAtual = lista1[lista1.NumeroDoNoAtual];

                if (registroAtual != null)
                {
                    registroAtual.Dica = txtDica.Text;
                }
            }
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
