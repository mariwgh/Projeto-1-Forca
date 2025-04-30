namespace apListaLigada
{
  partial class FrmAlunos
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunos));
            this.label2 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnFim = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tpListagem = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTras = new System.Windows.Forms.RadioButton();
            this.rbFrente = new System.Windows.Forms.RadioButton();
            this.lsbDados = new System.Windows.Forms.ListBox();
            this.tpForca = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slRegistro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tpListagem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dica:";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(79, 18);
            this.txtRA.MaxLength = 30;
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(207, 24);
            this.txtRA.TabIndex = 3;
            this.txtRA.TextChanged += new System.EventHandler(this.txtRA_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(524, 24);
            this.txtNome.TabIndex = 4;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.txt";
            this.dlgAbrir.Filter = "Arquivos de texto|*.txt|Qualquer arquivo|*.*";
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.DefaultExt = "*.txt";
            this.dlgSalvar.Title = "Selecione o arquivo para gravação dos dados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnFim,
            this.toolStripSeparator1,
            this.btnBuscar,
            this.toolStripSeparator3,
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnExcluir,
            this.toolStripSeparator2,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 38);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(40, 35);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(54, 35);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(55, 35);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnFim
            // 
            this.btnFim.Image = ((System.Drawing.Image)(resources.GetObject("btnFim.Image")));
            this.btnFim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(36, 35);
            this.btnFim.Text = "Final";
            this.btnFim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 35);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 35);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 35);
            this.btnEditar.Text = "Alterar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 35);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 35);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 35);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCadastro);
            this.tabControl1.Controls.Add(this.tpListagem);
            this.tabControl1.Controls.Add(this.tpForca);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 326);
            this.tabControl1.TabIndex = 22;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.txtRA);
            this.tpCadastro.Controls.Add(this.txtNome);
            this.tpCadastro.Location = new System.Drawing.Point(4, 26);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(609, 296);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palavra:";
            // 
            // tpListagem
            // 
            this.tpListagem.Controls.Add(this.groupBox1);
            this.tpListagem.Controls.Add(this.lsbDados);
            this.tpListagem.Location = new System.Drawing.Point(4, 22);
            this.tpListagem.Name = "tpListagem";
            this.tpListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tpListagem.Size = new System.Drawing.Size(609, 300);
            this.tpListagem.TabIndex = 1;
            this.tpListagem.Text = "Listagem";
            this.tpListagem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTras);
            this.groupBox1.Controls.Add(this.rbFrente);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem";
            // 
            // rbTras
            // 
            this.rbTras.AutoSize = true;
            this.rbTras.Location = new System.Drawing.Point(121, 22);
            this.rbTras.Name = "rbTras";
            this.rbTras.Size = new System.Drawing.Size(110, 21);
            this.rbTras.TabIndex = 1;
            this.rbTras.Text = "Decrescente";
            this.rbTras.UseVisualStyleBackColor = true;
            this.rbTras.Click += new System.EventHandler(this.rbTras_Click);
            // 
            // rbFrente
            // 
            this.rbFrente.AutoSize = true;
            this.rbFrente.Checked = true;
            this.rbFrente.Location = new System.Drawing.Point(6, 22);
            this.rbFrente.Name = "rbFrente";
            this.rbFrente.Size = new System.Drawing.Size(94, 21);
            this.rbFrente.TabIndex = 0;
            this.rbFrente.TabStop = true;
            this.rbFrente.Text = "Crescente";
            this.rbFrente.UseVisualStyleBackColor = true;
            this.rbFrente.Click += new System.EventHandler(this.rbFrente_Click);
            // 
            // lsbDados
            // 
            this.lsbDados.FormattingEnabled = true;
            this.lsbDados.ItemHeight = 17;
            this.lsbDados.Location = new System.Drawing.Point(7, 62);
            this.lsbDados.Name = "lsbDados";
            this.lsbDados.Size = new System.Drawing.Size(596, 225);
            this.lsbDados.TabIndex = 0;
            // 
            // tpForca
            // 
            this.tpForca.Location = new System.Drawing.Point(4, 22);
            this.tpForca.Name = "tpForca";
            this.tpForca.Padding = new System.Windows.Forms.Padding(3);
            this.tpForca.Size = new System.Drawing.Size(609, 300);
            this.tpForca.TabIndex = 2;
            this.tpForca.Text = "Forca";
            this.tpForca.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slRegistro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // slRegistro
            // 
            this.slRegistro.Name = "slRegistro";
            this.slRegistro.Size = new System.Drawing.Size(70, 17);
            this.slRegistro.Text = "Registro:0/0";
            // 
            // FrmAlunos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(634, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAlunos";
            this.Text = "Manutenção de Dicionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlunos_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.tpListagem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtRA;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
    private System.Windows.Forms.SaveFileDialog dlgSalvar;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton btnInicio;
    private System.Windows.Forms.ToolStripButton btnAnterior;
    private System.Windows.Forms.ToolStripButton btnProximo;
    private System.Windows.Forms.ToolStripButton btnFim;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton btnNovo;
    private System.Windows.Forms.ToolStripButton btnEditar;
    private System.Windows.Forms.ToolStripButton btnCancelar;
    private System.Windows.Forms.ToolStripButton btnExcluir;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnSair;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpCadastro;
    private System.Windows.Forms.TabPage tpListagem;
    private System.Windows.Forms.ToolStripButton btnBuscar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbTras;
    private System.Windows.Forms.RadioButton rbFrente;
    private System.Windows.Forms.ListBox lsbDados;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel slRegistro;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tpForca;
  }
}

