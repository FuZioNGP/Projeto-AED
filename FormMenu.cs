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

        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
        }

        private void BotaoEstoque_Click(object sender, EventArgs e)
        {
        }
        private void BotaoRemover_Click(object sender, EventArgs e)
        {
            
        }
        private void BotaoPesquisar_Click(object sender, EventArgs e)
        {

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
    }
}
