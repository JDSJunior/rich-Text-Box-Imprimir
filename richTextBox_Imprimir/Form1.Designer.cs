namespace richTextBox_Imprimir
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraçõesDeImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripNegrito = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConfigurarImpressao = new System.Windows.Forms.ToolStripButton();
            this.toolStripVisualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAjuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.rtxtb1 = new System.Windows.Forms.RichTextBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.svdlg1 = new System.Windows.Forms.SaveFileDialog();
            this.prntdlg1 = new System.Windows.Forms.PrintDialog();
            this.prntdoc1 = new System.Drawing.Printing.PrintDocument();
            this.prntprvdlg1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontdlg1 = new System.Windows.Forms.FontDialog();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirTextoToolStripMenuItem,
            this.salvarTextoToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirTextoToolStripMenuItem
            // 
            this.abrirTextoToolStripMenuItem.Name = "abrirTextoToolStripMenuItem";
            this.abrirTextoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirTextoToolStripMenuItem.Text = "&Abrir Texto";
            this.abrirTextoToolStripMenuItem.Click += new System.EventHandler(this.abrirTextoToolStripMenuItem_Click);
            // 
            // salvarTextoToolStripMenuItem
            // 
            this.salvarTextoToolStripMenuItem.Name = "salvarTextoToolStripMenuItem";
            this.salvarTextoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarTextoToolStripMenuItem.Text = "&Salvar Texto";
            this.salvarTextoToolStripMenuItem.Click += new System.EventHandler(this.salvarTextoToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copiarToolStripMenuItem.Text = "Co&piar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colarToolStripMenuItem.Text = "Co&lar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "S&air";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alterarFonteToolStripMenuItem,
            this.alinharTextoToolStripMenuItem,
            this.toolStripSeparator2,
            this.configuraçõesDeImpressãoToolStripMenuItem,
            this.visualizarImpressãoToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.negritoToolStripMenuItem.Text = "&Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.itálicoToolStripMenuItem.Text = "&Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.sublinhadoToolStripMenuItem.Text = "&Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alterarFonteToolStripMenuItem
            // 
            this.alterarFonteToolStripMenuItem.Name = "alterarFonteToolStripMenuItem";
            this.alterarFonteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.alterarFonteToolStripMenuItem.Text = "&Alterar Fonte";
            this.alterarFonteToolStripMenuItem.Click += new System.EventHandler(this.alterarFonteToolStripMenuItem_Click);
            // 
            // alinharTextoToolStripMenuItem
            // 
            this.alinharTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.centroToolStripMenuItem});
            this.alinharTextoToolStripMenuItem.Name = "alinharTextoToolStripMenuItem";
            this.alinharTextoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.alinharTextoToolStripMenuItem.Text = "Alinhar Texto";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            this.centroToolStripMenuItem.Click += new System.EventHandler(this.centroToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // configuraçõesDeImpressãoToolStripMenuItem
            // 
            this.configuraçõesDeImpressãoToolStripMenuItem.Name = "configuraçõesDeImpressãoToolStripMenuItem";
            this.configuraçõesDeImpressãoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.configuraçõesDeImpressãoToolStripMenuItem.Text = "&Configurações de Impressão";
            this.configuraçõesDeImpressãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesDeImpressãoToolStripMenuItem_Click);
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            this.visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            this.visualizarImpressãoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.visualizarImpressãoToolStripMenuItem.Text = "&Visualizar Impressão";
            this.visualizarImpressãoToolStripMenuItem.Click += new System.EventHandler(this.visualizarImpressãoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNovo,
            this.toolStripAbrir,
            this.toolStripSalvar,
            this.toolStripCopiar,
            this.toolStripColar,
            this.toolStripSeparator3,
            this.toolStripUndo,
            this.toolStripRedo,
            this.toolStripNegrito,
            this.toolStripItalico,
            this.toolStripSublinhado,
            this.toolStripFonte,
            this.toolStripSeparator4,
            this.toolStripConfigurarImpressao,
            this.toolStripVisualizar,
            this.toolStripImprimir,
            this.toolStripSeparator5,
            this.toolStripAjuda,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(488, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStripNovo";
            // 
            // toolStripNovo
            // 
            this.toolStripNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNovo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNovo.Image")));
            this.toolStripNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNovo.Name = "toolStripNovo";
            this.toolStripNovo.Size = new System.Drawing.Size(23, 22);
            this.toolStripNovo.Text = "Novo";
            this.toolStripNovo.Click += new System.EventHandler(this.toolStripNovo_Click);
            // 
            // toolStripAbrir
            // 
            this.toolStripAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAbrir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAbrir.Image")));
            this.toolStripAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAbrir.Name = "toolStripAbrir";
            this.toolStripAbrir.Size = new System.Drawing.Size(23, 22);
            this.toolStripAbrir.Text = "Abrir";
            this.toolStripAbrir.Click += new System.EventHandler(this.toolStripAbrir_Click);
            // 
            // toolStripSalvar
            // 
            this.toolStripSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSalvar.Image")));
            this.toolStripSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvar.Name = "toolStripSalvar";
            this.toolStripSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolStripSalvar.Text = "Salvar";
            this.toolStripSalvar.Click += new System.EventHandler(this.toolStripSalvar_Click);
            // 
            // toolStripCopiar
            // 
            this.toolStripCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopiar.Image")));
            this.toolStripCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopiar.Name = "toolStripCopiar";
            this.toolStripCopiar.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopiar.Text = "Copiar";
            this.toolStripCopiar.Click += new System.EventHandler(this.toolStripCopiar_Click);
            // 
            // toolStripColar
            // 
            this.toolStripColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripColar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripColar.Image")));
            this.toolStripColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripColar.Name = "toolStripColar";
            this.toolStripColar.Size = new System.Drawing.Size(23, 22);
            this.toolStripColar.Text = "Colar";
            this.toolStripColar.Click += new System.EventHandler(this.toolStripColar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripNegrito
            // 
            this.toolStripNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNegrito.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNegrito.Image")));
            this.toolStripNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNegrito.Name = "toolStripNegrito";
            this.toolStripNegrito.Size = new System.Drawing.Size(23, 22);
            this.toolStripNegrito.Text = "Negrito";
            this.toolStripNegrito.Click += new System.EventHandler(this.toolStripNegrito_Click);
            // 
            // toolStripItalico
            // 
            this.toolStripItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalico.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItalico.Image")));
            this.toolStripItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalico.Name = "toolStripItalico";
            this.toolStripItalico.Size = new System.Drawing.Size(23, 22);
            this.toolStripItalico.Text = "Italico";
            this.toolStripItalico.Click += new System.EventHandler(this.toolStripItalico_Click);
            // 
            // toolStripSublinhado
            // 
            this.toolStripSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSublinhado.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSublinhado.Image")));
            this.toolStripSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSublinhado.Name = "toolStripSublinhado";
            this.toolStripSublinhado.Size = new System.Drawing.Size(23, 22);
            this.toolStripSublinhado.Text = "Sublinhado";
            this.toolStripSublinhado.Click += new System.EventHandler(this.toolStripSublinhado_Click);
            // 
            // toolStripFonte
            // 
            this.toolStripFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFonte.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFonte.Image")));
            this.toolStripFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFonte.Name = "toolStripFonte";
            this.toolStripFonte.Size = new System.Drawing.Size(23, 22);
            this.toolStripFonte.Text = "Fonte";
            this.toolStripFonte.Click += new System.EventHandler(this.toolStripFonte_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripConfigurarImpressao
            // 
            this.toolStripConfigurarImpressao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripConfigurarImpressao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConfigurarImpressao.Image")));
            this.toolStripConfigurarImpressao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConfigurarImpressao.Name = "toolStripConfigurarImpressao";
            this.toolStripConfigurarImpressao.Size = new System.Drawing.Size(23, 22);
            this.toolStripConfigurarImpressao.Text = "Configuar Impressão";
            this.toolStripConfigurarImpressao.Click += new System.EventHandler(this.toolStripConfigurarImpressao_Click);
            // 
            // toolStripVisualizar
            // 
            this.toolStripVisualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripVisualizar.Image")));
            this.toolStripVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripVisualizar.Name = "toolStripVisualizar";
            this.toolStripVisualizar.Size = new System.Drawing.Size(23, 22);
            this.toolStripVisualizar.Text = "Visualizar";
            this.toolStripVisualizar.Click += new System.EventHandler(this.toolStripVisualizar_Click);
            // 
            // toolStripImprimir
            // 
            this.toolStripImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripImprimir.Image")));
            this.toolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripImprimir.Name = "toolStripImprimir";
            this.toolStripImprimir.Size = new System.Drawing.Size(23, 22);
            this.toolStripImprimir.Text = "Imprimir";
            this.toolStripImprimir.Click += new System.EventHandler(this.toolStripImprimir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripAjuda
            // 
            this.toolStripAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAjuda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAjuda.Image")));
            this.toolStripAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAjuda.Name = "toolStripAjuda";
            this.toolStripAjuda.Size = new System.Drawing.Size(23, 22);
            this.toolStripAjuda.Text = "Ajuda";
            this.toolStripAjuda.Click += new System.EventHandler(this.toolStripAjuda_Click);
            // 
            // toolStripSair
            // 
            this.toolStripSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSair.Image")));
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(23, 22);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // rtxtb1
            // 
            this.rtxtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtb1.Location = new System.Drawing.Point(0, 49);
            this.rtxtb1.Name = "rtxtb1";
            this.rtxtb1.Size = new System.Drawing.Size(488, 266);
            this.rtxtb1.TabIndex = 2;
            this.rtxtb1.Text = "";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // prntdlg1
            // 
            this.prntdlg1.UseEXDialog = true;
            // 
            // prntdoc1
            // 
            this.prntdoc1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prntdoc1_PrintPage);
            // 
            // prntprvdlg1
            // 
            this.prntprvdlg1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prntprvdlg1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prntprvdlg1.ClientSize = new System.Drawing.Size(400, 300);
            this.prntprvdlg1.Enabled = true;
            this.prntprvdlg1.Icon = ((System.Drawing.Icon)(resources.GetObject("prntprvdlg1.Icon")));
            this.prntprvdlg1.Name = "prntprvdlg1";
            this.prntprvdlg1.Visible = false;
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndo.Image")));
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripUndo.Text = "Desfazer";
            this.toolStripUndo.Click += new System.EventHandler(this.toolStripUndo_Click);
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedo.Image")));
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripRedo.Text = "Refazer";
            this.toolStripRedo.Click += new System.EventHandler(this.toolStripRedo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 315);
            this.Controls.Add(this.rtxtb1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Meu Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox rtxtb1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog svdlg1;
        private System.Windows.Forms.PrintDialog prntdlg1;
        private System.Drawing.Printing.PrintDocument prntdoc1;
        private System.Windows.Forms.PrintPreviewDialog prntprvdlg1;
        private System.Windows.Forms.FontDialog fontdlg1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinharTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDeImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripNovo;
        private System.Windows.Forms.ToolStripButton toolStripAbrir;
        private System.Windows.Forms.ToolStripButton toolStripSalvar;
        private System.Windows.Forms.ToolStripButton toolStripCopiar;
        private System.Windows.Forms.ToolStripButton toolStripColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripNegrito;
        private System.Windows.Forms.ToolStripButton toolStripItalico;
        private System.Windows.Forms.ToolStripButton toolStripSublinhado;
        private System.Windows.Forms.ToolStripButton toolStripFonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripVisualizar;
        private System.Windows.Forms.ToolStripButton toolStripImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripAjuda;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.ToolStripButton toolStripConfigurarImpressao;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
    }
}

