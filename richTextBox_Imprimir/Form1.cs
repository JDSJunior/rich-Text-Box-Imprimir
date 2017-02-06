using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace richTextBox_Imprimir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringReader leitor = null;

        private void salvar_Arquivo()
        {
            try
            {
                //Pega o nome do arquivo para salvar
                if(this.svdlg1.ShowDialog() == DialogResult.OK)
                {
                    //abre um stream para a escrita e cria um streamwriter para implementar o stream
                    FileStream fs = new FileStream(svdlg1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();
                    //Escreve para o arquivo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    //Escreve n controle richtextbox
                    m_streamWriter.Write(this.rtxtb1.Text);
                    //fecha o arquivo
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chamaSalvarArquivo()
        {
           if(!string.IsNullOrEmpty(rtxtb1.Text))
            {
                if((MessageBox.Show("Deseja Salvar o Arquivo?","Salvar o Arquivo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes))
                {
                    salvar_Arquivo();
                }
            }
        }

        private void abrirArquivo()
        {
            //define as propriedades do controle
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Arquivo";
            ofd1.InitialDirectory = @"C:\Dados\";
            //filtra para exibir somente textos
            ofd1.Filter = "Imagens(*.TXT)|*.TXT|" + "All files(*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 1;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(ofd1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    //lê o arquivo usando a classe StreamReader
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    //lê cada linha do stream e faz o parse até a ultima linha
                    this.rtxtb1.Text = "";
                    string strLine = m_streamReader.ReadLine();
                    while (strLine != null)
                    {
                        this.rtxtb1.Text += strLine + "\n";
                        strLine = m_streamReader.ReadLine();
                    }
                    //fecha o stream
                    m_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Copiar()
        {
            if (rtxtb1.SelectionLength > 0)
            {
                rtxtb1.Copy();
            }
        }

        private void Colar()
        {
            rtxtb1.Paste();
        }

        private void Negritar()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool negrito = false;
            nome_fonte = rtxtb1.Font.Name;
            tamanho_fonte = rtxtb1.Font.Size;
            negrito = rtxtb1.Font.Bold;
            if (negrito == false)
            {
                rtxtb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
            }
            else
            {
                rtxtb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            }
        }

        private void Italico()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool italico = false;
            nome_fonte = rtxtb1.Font.Name;
            tamanho_fonte = rtxtb1.Font.Size;
            italico = rtxtb1.Font.Italic;
            if (italico == false)
            {
                rtxtb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
            else
            {
                rtxtb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
        }

        private void Sublinhado()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool sublinhado = false;
            nome_fonte = rtxtb1.Font.Name;
            tamanho_fonte = rtxtb1.Font.Size;
            sublinhado = rtxtb1.Font.Underline;
            if (sublinhado == false)
            {
                rtxtb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
            }
        }

        private void alterarFonte()
        {
            DialogResult result = fontdlg1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (rtxtb1.SelectionFont != null)
                {
                    rtxtb1.SelectionFont = fontdlg1.Font;
                }
            }
        }

        private void configuracoesImpressora()
        {
            try
            {
                this.prntdlg1.Document = this.prntdoc1;
                prntdlg1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void visualizarImpressao()
        {
            //visualizar impressao
            try
            {
                string strTexto = this.rtxtb1.Text;
                leitor = new StringReader(strTexto);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                var prn = printPreviewDialog1;
                prn.Document = this.prntdoc1;
                prn.Text = "JÚNIOR - Visualizando a impressão";
                prn.WindowState = FormWindowState.Maximized;
                prn.PrintPreviewControl.Zoom = 1;
                prn.FormBorderStyle = FormBorderStyle.Fixed3D;
                prn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimir()
        {
            prntdlg1.Document = prntdoc1;

            string strTexto = this.rtxtb1.Text;
            leitor = new StringReader(strTexto);
            if (prntdlg1.ShowDialog() == DialogResult.OK)
            {
                this.prntdoc1.Print();
            }

        }

        private void Sobre()
        {
            try
            {
                Sobre frm2 = new Sobre();
                frm2.ShowDialog();
                if (frm2.DialogResult == DialogResult.OK)
                {
                    frm2.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sair()
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void undo()
        {
            rtxtb1.Undo();
        }

        private void redo()
        {
            rtxtb1.Redo();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            prntdlg1.Document = prntdoc1;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamaSalvarArquivo();
            rtxtb1.Clear();
            rtxtb1.Focus();
        }

        private void toolStripNovo_Click(object sender, EventArgs e)
        {
            chamaSalvarArquivo();
            rtxtb1.Clear();
            rtxtb1.Focus();
        }

        private void salvarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamaSalvarArquivo();
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            chamaSalvarArquivo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void toolStripCopiar_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem.PerformClick();
        }

        private void toolStripColar_Click(object sender, EventArgs e)
        {
           Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negritar();
        }

        private void toolStripNegrito_Click(object sender, EventArgs e)
        {
            Negritar();
        }

        private void toolStripItalico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void toolStripSublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void toolStripFonte_Click(object sender, EventArgs e)
        {
            alterarFonte();
        }

        private void alterarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterarFonte();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtb1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtb1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtb1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void configuraçõesDeImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuracoesImpressora();
        }

        private void toolStripImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void toolStripVisualizar_Click(object sender, EventArgs e)
        {
            visualizarImpressao();
        }

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizarImpressao();
        }

        private void prntdoc1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPorPagina = 0;
            float posicao_Y = 0;
            float contador = 0;

            //define as margens eo valor minimo
            float margenEsquerda = e.MarginBounds.Left - 50;
            float margenSuperior = e.MarginBounds.Top - 50;

            if (margenEsquerda < 5)
            {
                margenEsquerda = 20;
            }

            if (margenSuperior < 5)
            {
                margenSuperior = 20;
            }

            //define a fonte
            string linha = null;
            Font fonteDeImpressao = this.rtxtb1.Font;
            SolidBrush meuPincel = new SolidBrush(Color.Black);

            //Calcula o numero de linhas por pagina usando as medidas das margens
            linhasPorPagina = e.MarginBounds.Height / fonteDeImpressao.GetHeight(e.Graphics);

            //imprime cada linha usando um StreamReader
            linha = leitor.ReadLine();

            while (contador < linhasPorPagina)
            {
                //calcula a posicao linha baseado na altura de acordo com o dispositivo de impresão
                posicao_Y = (margenSuperior + (contador * fonteDeImpressao.GetHeight(e.Graphics)));

                //desenha a proxima linha no controle richtextbox
                e.Graphics.DrawString(linha, fonteDeImpressao, meuPincel, margenEsquerda, posicao_Y, new StringFormat());
                
                //conta a linha e incrementa uma unidade
                contador += 1;
                linha = leitor.ReadLine();
            }
            //se existir mais linhas imprimi outra página
            if ((linha != null))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            meuPincel.Dispose();
        }

        private void toolStripConfigurarImpressao_Click(object sender, EventArgs e)
        {
            configuracoesImpressora();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sobre();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre();
        }

        private void toolStripAjuda_Click(object sender, EventArgs e)
        {
            Sobre();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            abrirArquivo();
        }

        private void abrirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArquivo();
        }

        private void toolStripUndo_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void toolStripRedo_Click(object sender, EventArgs e)
        {
            redo();
        }





    }
}
