namespace Locadora
{
    partial class FormCarro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarro));
            pictureBox2 = new PictureBox();
            label5 = new Label();
            txtMarca = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtModelo = new TextBox();
            label3 = new Label();
            txtPlaca = new TextBox();
            label4 = new Label();
            txtCor = new TextBox();
            ckDis = new CheckBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            listCarros = new ListView();
            Id = new ColumnHeader();
            Marca = new ColumnHeader();
            Modelo = new ColumnHeader();
            placa = new ColumnHeader();
            cor = new ColumnHeader();
            Status = new ColumnHeader();
            contextMenuCarro = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuCarro.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 100);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(260, 49);
            label5.Name = "label5";
            label5.Size = new Size(106, 40);
            label5.TabIndex = 13;
            label5.Text = "Carros";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 144);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(202, 23);
            txtMarca.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(220, 126);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 17;
            label2.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(220, 144);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(198, 23);
            txtModelo.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 19;
            label3.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(12, 191);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(202, 23);
            txtPlaca.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(220, 173);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 21;
            label4.Text = "Cor";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(220, 191);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(202, 23);
            txtCor.TabIndex = 20;
            // 
            // ckDis
            // 
            ckDis.AutoSize = true;
            ckDis.Location = new Point(12, 220);
            ckDis.Name = "ckDis";
            ckDis.Size = new Size(89, 19);
            ckDis.TabIndex = 23;
            ckDis.Text = "Disponível ?";
            ckDis.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(428, 126);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(136, 45);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(428, 177);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 37);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // listCarros
            // 
            listCarros.Columns.AddRange(new ColumnHeader[] { Id, Marca, Modelo, placa, cor, Status });
            listCarros.ContextMenuStrip = contextMenuCarro;
            listCarros.FullRowSelect = true;
            listCarros.Location = new Point(12, 245);
            listCarros.Name = "listCarros";
            listCarros.Size = new Size(552, 128);
            listCarros.TabIndex = 26;
            listCarros.UseCompatibleStateImageBehavior = false;
            listCarros.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 58;
            // 
            // Marca
            // 
            Marca.Text = "Marca";
            Marca.Width = 130;
            // 
            // Modelo
            // 
            Modelo.Text = "Modelo";
            Modelo.Width = 100;
            // 
            // placa
            // 
            placa.Text = "Placa";
            placa.Width = 80;
            // 
            // cor
            // 
            cor.Text = "Cor";
            cor.Width = 100;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 80;
            // 
            // contextMenuCarro
            // 
            contextMenuCarro.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, excluirToolStripMenuItem });
            contextMenuCarro.Name = "contextMenuCarro";
            contextMenuCarro.Size = new Size(181, 70);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(180, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(180, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // FormCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 385);
            Controls.Add(listCarros);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(ckDis);
            Controls.Add(label4);
            Controls.Add(txtCor);
            Controls.Add(label3);
            Controls.Add(txtPlaca);
            Controls.Add(label2);
            Controls.Add(txtModelo);
            Controls.Add(label1);
            Controls.Add(txtMarca);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Name = "FormCarro";
            Text = "Carros";
            Load += FormCarro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuCarro.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label5;
        private TextBox txtMarca;
        private Label label1;
        private Label label2;
        private TextBox txtModelo;
        private Label label3;
        private TextBox txtPlaca;
        private Label label4;
        private TextBox txtCor;
        private CheckBox ckDis;
        private Button btnSalvar;
        private Button btnCancelar;
        private ListView listCarros;
        private ColumnHeader Id;
        private ColumnHeader Marca;
        private ColumnHeader Modelo;
        private ColumnHeader placa;
        private ColumnHeader cor;
        private ColumnHeader Status;
        private ContextMenuStrip contextMenuCarro;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
    }
}