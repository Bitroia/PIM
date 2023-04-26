namespace PIM_CASI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHole = new System.Windows.Forms.Button();
            this.btnAddHora = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnAddFun = new System.Windows.Forms.Button();
            this.btnFun = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelMenu.Controls.Add(this.btnEditar);
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnHole);
            this.panelMenu.Controls.Add(this.btnAddHora);
            this.panelMenu.Controls.Add(this.btnPonto);
            this.panelMenu.Controls.Add(this.btnAddFun);
            this.panelMenu.Controls.Add(this.btnFun);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 800);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(0, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(300, 60);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "  Editar Funcionario";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 740);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(300, 60);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnHole
            // 
            this.btnHole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHole.FlatAppearance.BorderSize = 0;
            this.btnHole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnHole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnHole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHole.Image = ((System.Drawing.Image)(resources.GetObject("btnHole.Image")));
            this.btnHole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHole.Location = new System.Drawing.Point(0, 320);
            this.btnHole.Name = "btnHole";
            this.btnHole.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHole.Size = new System.Drawing.Size(300, 60);
            this.btnHole.TabIndex = 6;
            this.btnHole.Text = "  Holerite";
            this.btnHole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHole.UseVisualStyleBackColor = true;
            this.btnHole.Click += new System.EventHandler(this.btnHole_Click);
            // 
            // btnAddHora
            // 
            this.btnAddHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddHora.FlatAppearance.BorderSize = 0;
            this.btnAddHora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddHora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAddHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddHora.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHora.Image")));
            this.btnAddHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHora.Location = new System.Drawing.Point(0, 260);
            this.btnAddHora.Name = "btnAddHora";
            this.btnAddHora.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddHora.Size = new System.Drawing.Size(300, 60);
            this.btnAddHora.TabIndex = 4;
            this.btnAddHora.Text = "Registro de Pronto";
            this.btnAddHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddHora.UseVisualStyleBackColor = true;
            this.btnAddHora.Click += new System.EventHandler(this.btnAddHora_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPonto.FlatAppearance.BorderSize = 0;
            this.btnPonto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPonto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPonto.Image = ((System.Drawing.Image)(resources.GetObject("btnPonto.Image")));
            this.btnPonto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonto.Location = new System.Drawing.Point(0, 200);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPonto.Size = new System.Drawing.Size(300, 60);
            this.btnPonto.TabIndex = 3;
            this.btnPonto.Text = "  Ponto";
            this.btnPonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnAddFun
            // 
            this.btnAddFun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddFun.FlatAppearance.BorderSize = 0;
            this.btnAddFun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddFun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAddFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddFun.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFun.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFun.Image")));
            this.btnAddFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFun.Location = new System.Drawing.Point(0, 140);
            this.btnAddFun.Name = "btnAddFun";
            this.btnAddFun.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddFun.Size = new System.Drawing.Size(300, 60);
            this.btnAddFun.TabIndex = 2;
            this.btnAddFun.Text = "  Criar Funcionarios";
            this.btnAddFun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFun.UseVisualStyleBackColor = true;
            this.btnAddFun.Click += new System.EventHandler(this.btnAddFun_Click);
            // 
            // btnFun
            // 
            this.btnFun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFun.FlatAppearance.BorderSize = 0;
            this.btnFun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnFun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnFun.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFun.Image = ((System.Drawing.Image)(resources.GetObject("btnFun.Image")));
            this.btnFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFun.Location = new System.Drawing.Point(0, 80);
            this.btnFun.Name = "btnFun";
            this.btnFun.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFun.Size = new System.Drawing.Size(300, 60);
            this.btnFun.TabIndex = 1;
            this.btnFun.Text = "  Funcionarios";
            this.btnFun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFun.UseVisualStyleBackColor = true;
            this.btnFun.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(300, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(980, 800);
            this.panelForm.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento ";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHole;
        private System.Windows.Forms.Button btnAddHora;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnAddFun;
        private System.Windows.Forms.Button btnFun;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnEditar;
    }
}

