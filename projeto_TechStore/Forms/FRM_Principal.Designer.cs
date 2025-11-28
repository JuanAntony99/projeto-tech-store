namespace projeto_TechStore
{
    partial class FRM_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pctbox_produtos = new System.Windows.Forms.PictureBox();
            this.pctbox_clientes = new System.Windows.Forms.PictureBox();
            this.pctbox_vendas = new System.Windows.Forms.PictureBox();
            this.pctbox_home = new System.Windows.Forms.PictureBox();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelPrincipal.Controls.Add(this.pctbox_produtos);
            this.panelPrincipal.Controls.Add(this.pctbox_clientes);
            this.panelPrincipal.Controls.Add(this.pctbox_vendas);
            this.panelPrincipal.Controls.Add(this.pctbox_home);
            this.panelPrincipal.Controls.Add(this.btn_produtos);
            this.panelPrincipal.Controls.Add(this.btn_clientes);
            this.panelPrincipal.Controls.Add(this.btn_vendas);
            this.panelPrincipal.Controls.Add(this.btn_home);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Controls.Add(this.pictureBox2);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(133, 450);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // pctbox_produtos
            // 
            this.pctbox_produtos.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_produtos.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_produtos.Image")));
            this.pctbox_produtos.Location = new System.Drawing.Point(75, 201);
            this.pctbox_produtos.Name = "pctbox_produtos";
            this.pctbox_produtos.Size = new System.Drawing.Size(42, 39);
            this.pctbox_produtos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_produtos.TabIndex = 27;
            this.pctbox_produtos.TabStop = false;
            // 
            // pctbox_clientes
            // 
            this.pctbox_clientes.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_clientes.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_clientes.Image")));
            this.pctbox_clientes.Location = new System.Drawing.Point(75, 156);
            this.pctbox_clientes.Name = "pctbox_clientes";
            this.pctbox_clientes.Size = new System.Drawing.Size(42, 39);
            this.pctbox_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_clientes.TabIndex = 28;
            this.pctbox_clientes.TabStop = false;
            // 
            // pctbox_vendas
            // 
            this.pctbox_vendas.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_vendas.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_vendas.Image")));
            this.pctbox_vendas.Location = new System.Drawing.Point(75, 111);
            this.pctbox_vendas.Name = "pctbox_vendas";
            this.pctbox_vendas.Size = new System.Drawing.Size(42, 39);
            this.pctbox_vendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_vendas.TabIndex = 27;
            this.pctbox_vendas.TabStop = false;
            // 
            // pctbox_home
            // 
            this.pctbox_home.BackColor = System.Drawing.Color.Transparent;
            this.pctbox_home.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_home.Image")));
            this.pctbox_home.Location = new System.Drawing.Point(75, 66);
            this.pctbox_home.Name = "pctbox_home";
            this.pctbox_home.Size = new System.Drawing.Size(42, 39);
            this.pctbox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_home.TabIndex = 26;
            this.pctbox_home.TabStop = false;
            // 
            // btn_produtos
            // 
            this.btn_produtos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_produtos.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_produtos.FlatAppearance.BorderSize = 0;
            this.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.ForeColor = System.Drawing.Color.White;
            this.btn_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_produtos.Location = new System.Drawing.Point(0, 195);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(133, 45);
            this.btn_produtos.TabIndex = 4;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_produtos.UseVisualStyleBackColor = true;
            this.btn_produtos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.White;
            this.btn_clientes.Location = new System.Drawing.Point(0, 150);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(133, 45);
            this.btn_clientes.TabIndex = 3;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vendas.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_vendas.FlatAppearance.BorderSize = 0;
            this.btn_vendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_vendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btn_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vendas.ForeColor = System.Drawing.Color.White;
            this.btn_vendas.Location = new System.Drawing.Point(0, 105);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(133, 45);
            this.btn_vendas.TabIndex = 2;
            this.btn_vendas.Text = "Vendas";
            this.btn_vendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_vendas.UseVisualStyleBackColor = true;
            this.btn_vendas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 60);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(133, 45);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 60);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel_Form
            // 
            this.panel_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Form.BackColor = System.Drawing.Color.White;
            this.panel_Form.Controls.Add(this.label1);
            this.panel_Form.Controls.Add(this.pictureBox1);
            this.panel_Form.Location = new System.Drawing.Point(123, 0);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(677, 450);
            this.panel_Form.TabIndex = 1;
            this.panel_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Form_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Vendas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 48);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Form);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FRM_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Principal_Load_1);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_Form.ResumeLayout(false);
            this.panel_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pctbox_home;
        private System.Windows.Forms.PictureBox pctbox_produtos;
        private System.Windows.Forms.PictureBox pctbox_clientes;
        private System.Windows.Forms.PictureBox pctbox_vendas;
    }
}

