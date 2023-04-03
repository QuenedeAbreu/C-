namespace Locadora
{
    partial class FormLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocacao));
            pictureBox2 = new PictureBox();
            label5 = new Label();
            cbUsuario = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbCarro = new ComboBox();
            btnProcessar = new Button();
            listAlugel = new ListView();
            id = new ColumnHeader();
            Modelo = new ColumnHeader();
            Placa = new ColumnHeader();
            usuario = new ColumnHeader();
            DataLocacao = new ColumnHeader();
            DataDevolucao = new ColumnHeader();
            ValorDiaria = new ColumnHeader();
            Diarias = new ColumnHeader();
            valorPago = new ColumnHeader();
            menuLocacao = new ContextMenuStrip(components);
            devolverCarro = new ToolStripMenuItem();
            txtDataLocacao = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            txtDevolucao = new MaskedTextBox();
            txtValorDiaria = new MaskedTextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuLocacao.SuspendLayout();
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
            pictureBox2.Size = new Size(105, 100);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(246, 12);
            label5.Name = "label5";
            label5.Size = new Size(128, 40);
            label5.TabIndex = 14;
            label5.Text = "Locação";
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(154, 80);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(176, 23);
            cbUsuario.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 62);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 16;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(334, 62);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 18;
            label2.Text = "Carros Disponíveis";
            // 
            // cbCarro
            // 
            cbCarro.FormattingEnabled = true;
            cbCarro.Location = new Point(336, 80);
            cbCarro.Name = "cbCarro";
            cbCarro.Size = new Size(176, 23);
            cbCarro.TabIndex = 17;
            // 
            // btnProcessar
            // 
            btnProcessar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcessar.Location = new Point(422, 126);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(122, 41);
            btnProcessar.TabIndex = 19;
            btnProcessar.Text = "Processar";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnAlugar_Click;
            // 
            // listAlugel
            // 
            listAlugel.Columns.AddRange(new ColumnHeader[] { id, Modelo, Placa, usuario, DataLocacao, DataDevolucao, ValorDiaria, Diarias, valorPago });
            listAlugel.ContextMenuStrip = menuLocacao;
            listAlugel.FullRowSelect = true;
            listAlugel.Location = new Point(10, 184);
            listAlugel.Name = "listAlugel";
            listAlugel.Size = new Size(644, 125);
            listAlugel.TabIndex = 20;
            listAlugel.UseCompatibleStateImageBehavior = false;
            listAlugel.View = View.Details;
            listAlugel.ItemSelectionChanged += listAlugel_ItemSelectionChanged;
            // 
            // id
            // 
            id.Text = "Id";
            id.Width = 40;
            // 
            // Modelo
            // 
            Modelo.Text = "Modelo";
            // 
            // Placa
            // 
            Placa.Text = "Placa";
            // 
            // usuario
            // 
            usuario.Text = "Usuario";
            // 
            // DataLocacao
            // 
            DataLocacao.Text = "Data Locação";
            DataLocacao.Width = 90;
            // 
            // DataDevolucao
            // 
            DataDevolucao.Text = "Data Devolução";
            DataDevolucao.Width = 90;
            // 
            // ValorDiaria
            // 
            ValorDiaria.Text = "Valor Diária";
            ValorDiaria.Width = 90;
            // 
            // Diarias
            // 
            Diarias.Text = "Diaria(s)";
            // 
            // valorPago
            // 
            valorPago.Text = "ValorPago";
            valorPago.Width = 90;
            // 
            // menuLocacao
            // 
            menuLocacao.Items.AddRange(new ToolStripItem[] { devolverCarro });
            menuLocacao.Name = "menuLocacao";
            menuLocacao.Size = new Size(181, 48);
            // 
            // devolverCarro
            // 
            devolverCarro.Name = "devolverCarro";
            devolverCarro.Size = new Size(180, 22);
            devolverCarro.Text = "Devolver Carro";
            devolverCarro.Click += devolverCarro_Click;
            // 
            // txtDataLocacao
            // 
            txtDataLocacao.Location = new Point(12, 144);
            txtDataLocacao.Mask = "00/00/0000";
            txtDataLocacao.Name = "txtDataLocacao";
            txtDataLocacao.Size = new Size(146, 23);
            txtDataLocacao.TabIndex = 21;
            txtDataLocacao.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 126);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 22;
            label3.Text = "Data Locação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(163, 126);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 24;
            label4.Text = "Data Devolucao";
            // 
            // txtDevolucao
            // 
            txtDevolucao.Location = new Point(164, 144);
            txtDevolucao.Mask = "00/00/0000";
            txtDevolucao.Name = "txtDevolucao";
            txtDevolucao.Size = new Size(146, 23);
            txtDevolucao.TabIndex = 23;
            txtDevolucao.ValidatingType = typeof(DateTime);
            // 
            // txtValorDiaria
            // 
            txtValorDiaria.Location = new Point(316, 144);
            txtValorDiaria.Name = "txtValorDiaria";
            txtValorDiaria.Size = new Size(100, 23);
            txtValorDiaria.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(316, 126);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 26;
            label6.Text = "Valor da Diária";
            // 
            // FormLocacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 316);
            Controls.Add(label6);
            Controls.Add(txtValorDiaria);
            Controls.Add(label4);
            Controls.Add(txtDevolucao);
            Controls.Add(label3);
            Controls.Add(txtDataLocacao);
            Controls.Add(listAlugel);
            Controls.Add(btnProcessar);
            Controls.Add(label2);
            Controls.Add(cbCarro);
            Controls.Add(label1);
            Controls.Add(cbUsuario);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Name = "FormLocacao";
            Text = "FormLocacao";
            Load += FormLocacao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuLocacao.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label5;
        private ComboBox cbUsuario;
        private Label label1;
        private Label label2;
        private ComboBox cbCarro;
        private Button btnProcessar;
        private ListView listAlugel;
        private ColumnHeader id;
        private ColumnHeader Modelo;
        private ColumnHeader Placa;
        private MaskedTextBox txtDataLocacao;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtDevolucao;
        private MaskedTextBox txtValorDiaria;
        private Label label6;
        private ColumnHeader usuario;
        private ColumnHeader DataLocacao;
        private ColumnHeader DataDevolucao;
        private ColumnHeader ValorDiaria;
        private ColumnHeader Diarias;
        private ColumnHeader valorPago;
        private ContextMenuStrip menuLocacao;
        private ToolStripMenuItem devolverCarro;
    }
}