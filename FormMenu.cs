using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace ProjetoAED
{
    public partial class FormMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }


        public FormMenu()
        {
            InitializeComponent();
        }


        private void BotaoMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void BotaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Cadastrar>();
        }

        private void BotaoEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<estoque>();
        }
        private void BotaoRemover_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<remover>();
        }
        private void BotaoPesquisar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<pesquisar>();
        }
        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<adicionar>();
        }
        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
