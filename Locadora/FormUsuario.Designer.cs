namespace Locadora
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            label1 = new Label();
            txtData = new MaskedTextBox();
            label2 = new Label();
            txtEmail = new MaskedTextBox();
            label3 = new Label();
            txtCpf = new MaskedTextBox();
            label4 = new Label();
            btnSalvar = new Button();
            listUsuarios = new ListView();
            Id = new ColumnHeader();
            Nome = new ColumnHeader();
            DataNascimento = new ColumnHeader();
            Email = new ColumnHeader();
            Cpf = new ColumnHeader();
            menuTabela = new ContextMenuStrip(components);
            Editar = new ToolStripMenuItem();
            Excluir = new ToolStripMenuItem();
            label5 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuTabela.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(35, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(147, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 63);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(353, 82);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(125, 23);
            txtData.TabIndex = 4;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(353, 63);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Data Nascimento";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(145, 113);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(353, 131);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(125, 23);
            txtCpf.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(351, 113);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 9;
            label4.Text = "CPF";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(488, 82);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(128, 46);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // listUsuarios
            // 
            listUsuarios.Columns.AddRange(new ColumnHeader[] { Id, Nome, DataNascimento, Email, Cpf });
            listUsuarios.ContextMenuStrip = menuTabela;
            listUsuarios.FullRowSelect = true;
            listUsuarios.GridLines = true;
            listUsuarios.Location = new Point(12, 160);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(604, 131);
            listUsuarios.TabIndex = 11;
            listUsuarios.UseCompatibleStateImageBehavior = false;
            listUsuarios.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 150;
            // 
            // DataNascimento
            // 
            DataNascimento.Text = "Data Nascimento";
            DataNascimento.Width = 110;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 160;
            // 
            // Cpf
            // 
            Cpf.Text = "C.P.F";
            Cpf.Width = 120;
            // 
            // menuTabela
            // 
            menuTabela.Items.AddRange(new ToolStripItem[] { Editar, Excluir });
            menuTabela.Name = "menuTabela";
            menuTabela.Size = new Size(110, 48);
            // 
            // Editar
            // 
            Editar.Name = "Editar";
            Editar.Size = new Size(109, 22);
            Editar.Text = "Editar";
            Editar.Click += Editar_Click;
            // 
            // Excluir
            // 
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(109, 22);
            Excluir.Text = "Excluir";
            Excluir.Click += Excluir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(249, 14);
            label5.Name = "label5";
            label5.Size = new Size(136, 40);
            label5.TabIndex = 12;
            label5.Text = "Usuários";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(488, 127);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(624, 303);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(listUsuarios);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtData);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Name = "FormUsuario";
            Text = "Usuarios";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuTabela.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNome;
        private Label label1;
        private MaskedTextBox txtData;
        private Label label2;
        private MaskedTextBox txtEmail;
        private Label label3;
        private MaskedTextBox txtCpf;
        private Label label4;
        private Button btnSalvar;
        private ListView listUsuarios;
        private Label label5;
        private ColumnHeader Id;
        private ColumnHeader Nome;
        private ColumnHeader DataNascimento;
        private ColumnHeader Email;
        private ColumnHeader Cpf;
        private ContextMenuStrip menuTabela;
        private ToolStripMenuItem Editar;
        private ToolStripMenuItem Excluir;
        private Button btnCancelar;
    }
}