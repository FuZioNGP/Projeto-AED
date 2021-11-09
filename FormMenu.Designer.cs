namespace ProjetoAED
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.BotaoMinimizar = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.BotaoMaximizar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BotaoPesquisar = new System.Windows.Forms.Button();
            this.BotaoRemover = new System.Windows.Forms.Button();
            this.BotaoEstoque = new System.Windows.Forms.Button();
            this.BotaoAdicionar = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.BotaoCadastrar = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.White;
            this.panelCabecalho.Controls.Add(this.BotaoMinimizar);
            this.panelCabecalho.Controls.Add(this.Title);
            this.panelCabecalho.Controls.Add(this.BotaoMaximizar);
            this.panelCabecalho.Controls.Add(this.BotaoFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 40);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // BotaoMinimizar
            // 
            this.BotaoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoMinimizar.BackColor = System.Drawing.Color.White;
            this.BotaoMinimizar.FlatAppearance.BorderSize = 0;
            this.BotaoMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotaoMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BotaoMinimizar.Image")));
            this.BotaoMinimizar.Location = new System.Drawing.Point(665, 3);
            this.BotaoMinimizar.Name = "BotaoMinimizar";
            this.BotaoMinimizar.Size = new System.Drawing.Size(40, 34);
            this.BotaoMinimizar.TabIndex = 2;
            this.BotaoMinimizar.UseVisualStyleBackColor = false;
            this.BotaoMinimizar.Click += new System.EventHandler(this.BotaoMinimizar_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Title.Location = new System.Drawing.Point(0, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(212, 30);
            this.Title.TabIndex = 1;
            this.Title.Text = "Controle de Estoque";
            // 
            // BotaoMaximizar
            // 
            this.BotaoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoMaximizar.BackColor = System.Drawing.Color.White;
            this.BotaoMaximizar.FlatAppearance.BorderSize = 0;
            this.BotaoMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotaoMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BotaoMaximizar.Image")));
            this.BotaoMaximizar.Location = new System.Drawing.Point(711, 3);
            this.BotaoMaximizar.Name = "BotaoMaximizar";
            this.BotaoMaximizar.Size = new System.Drawing.Size(40, 34);
            this.BotaoMaximizar.TabIndex = 0;
            this.BotaoMaximizar.UseVisualStyleBackColor = false;
            this.BotaoMaximizar.Click += new System.EventHandler(this.BotaoMaximizar_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoFechar.BackColor = System.Drawing.Color.White;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotaoFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.ForeColor = System.Drawing.Color.White;
            this.BotaoFechar.Image = ((System.Drawing.Image)(resources.GetObject("BotaoFechar.Image")));
            this.BotaoFechar.Location = new System.Drawing.Point(757, 3);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 34);
            this.BotaoFechar.TabIndex = 0;
            this.BotaoFechar.UseVisualStyleBackColor = false;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelMenu.Controls.Add(this.BotaoCadastrar);
            this.panelMenu.Controls.Add(this.BotaoPesquisar);
            this.panelMenu.Controls.Add(this.BotaoRemover);
            this.panelMenu.Controls.Add(this.BotaoEstoque);
            this.panelMenu.Controls.Add(this.BotaoAdicionar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(168, 491);
            this.panelMenu.TabIndex = 1;
            // 
            // BotaoPesquisar
            // 
            this.BotaoPesquisar.FlatAppearance.BorderSize = 0;
            this.BotaoPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoPesquisar.ForeColor = System.Drawing.Color.White;
            this.BotaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BotaoPesquisar.Image")));
            this.BotaoPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoPesquisar.Location = new System.Drawing.Point(0, 78);
            this.BotaoPesquisar.Name = "BotaoPesquisar";
            this.BotaoPesquisar.Size = new System.Drawing.Size(166, 71);
            this.BotaoPesquisar.TabIndex = 2;
            this.BotaoPesquisar.Text = "             PESQUISAR";
            this.BotaoPesquisar.UseVisualStyleBackColor = false;
            this.BotaoPesquisar.Click += new System.EventHandler(this.BotaoPesquisar_Click);
            // 
            // BotaoRemover
            // 
            this.BotaoRemover.FlatAppearance.BorderSize = 0;
            this.BotaoRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRemover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoRemover.ForeColor = System.Drawing.Color.White;
            this.BotaoRemover.Image = ((System.Drawing.Image)(resources.GetObject("BotaoRemover.Image")));
            this.BotaoRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoRemover.Location = new System.Drawing.Point(0, 221);
            this.BotaoRemover.Name = "BotaoRemover";
            this.BotaoRemover.Size = new System.Drawing.Size(166, 71);
            this.BotaoRemover.TabIndex = 1;
            this.BotaoRemover.Text = "         REMOVER";
            this.BotaoRemover.UseVisualStyleBackColor = false;
            this.BotaoRemover.Click += new System.EventHandler(this.BotaoRemover_Click);
            // 
            // BotaoEstoque
            // 
            this.BotaoEstoque.FlatAppearance.BorderSize = 0;
            this.BotaoEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEstoque.ForeColor = System.Drawing.Color.White;
            this.BotaoEstoque.Image = ((System.Drawing.Image)(resources.GetObject("BotaoEstoque.Image")));
            this.BotaoEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoEstoque.Location = new System.Drawing.Point(0, 6);
            this.BotaoEstoque.Name = "BotaoEstoque";
            this.BotaoEstoque.Size = new System.Drawing.Size(168, 66);
            this.BotaoEstoque.TabIndex = 0;
            this.BotaoEstoque.Text = "           ESTOQUE";
            this.BotaoEstoque.UseVisualStyleBackColor = true;
            this.BotaoEstoque.Click += new System.EventHandler(this.BotaoEstoque_Click);
            // 
            // BotaoAdicionar
            // 
            this.BotaoAdicionar.FlatAppearance.BorderSize = 0;
            this.BotaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoAdicionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAdicionar.ForeColor = System.Drawing.Color.White;
            this.BotaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BotaoAdicionar.Image")));
            this.BotaoAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoAdicionar.Location = new System.Drawing.Point(0, 144);
            this.BotaoAdicionar.Name = "BotaoAdicionar";
            this.BotaoAdicionar.Size = new System.Drawing.Size(166, 71);
            this.BotaoAdicionar.TabIndex = 0;
            this.BotaoAdicionar.Text = "             ADICIONAR";
            this.BotaoAdicionar.UseVisualStyleBackColor = false;
            this.BotaoAdicionar.Click += new System.EventHandler(this.BotaoAdicionar_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(168, 40);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(632, 491);
            this.panelConteudo.TabIndex = 2;
            this.panelConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConteudo_Paint);
            // 
            // BotaoCadastrar
            // 
            this.BotaoCadastrar.FlatAppearance.BorderSize = 0;
            this.BotaoCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotaoCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCadastrar.ForeColor = System.Drawing.Color.White;
            this.BotaoCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BotaoCadastrar.Image")));
            this.BotaoCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoCadastrar.Location = new System.Drawing.Point(0, 298);
            this.BotaoCadastrar.Name = "BotaoCadastrar";
            this.BotaoCadastrar.Size = new System.Drawing.Size(166, 71);
            this.BotaoCadastrar.TabIndex = 3;
            this.BotaoCadastrar.Text = "             CADASTRAR";
            this.BotaoCadastrar.UseVisualStyleBackColor = false;
            this.BotaoCadastrar.Click += new System.EventHandler(this.BotaoCadastrar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button BotaoMaximizar;
        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BotaoEstoque;
        private System.Windows.Forms.Button BotaoAdicionar;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button BotaoRemover;
        private System.Windows.Forms.Button BotaoMinimizar;
        private System.Windows.Forms.Button BotaoPesquisar;
        private System.Windows.Forms.Button BotaoCadastrar;
    }
}