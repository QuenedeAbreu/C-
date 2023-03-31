namespace Calculadora
{
    partial class Calcularoda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calcularoda));
            label1 = new Label();
            txtn1 = new TextBox();
            txtn2 = new TextBox();
            LbSinal = new Label();
            cbTipoCalculo = new ComboBox();
            label2 = new Label();
            btnCalcular = new Button();
            label3 = new Label();
            lbResultado = new Label();
            ListViewOp = new ListView();
            Operação = new ColumnHeader();
            Resultado = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "Calculadora";
            label1.Click += label1_Click;
            // 
            // txtn1
            // 
            txtn1.Location = new Point(12, 95);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(135, 23);
            txtn1.TabIndex = 1;
            txtn1.Text = "0";
            // 
            // txtn2
            // 
            txtn2.Location = new Point(189, 95);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(135, 23);
            txtn2.TabIndex = 2;
            txtn2.Text = "0";
            // 
            // LbSinal
            // 
            LbSinal.AutoSize = true;
            LbSinal.BackColor = Color.Transparent;
            LbSinal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LbSinal.ForeColor = Color.White;
            LbSinal.Location = new Point(155, 87);
            LbSinal.Name = "LbSinal";
            LbSinal.Size = new Size(25, 32);
            LbSinal.TabIndex = 3;
            LbSinal.Text = "?";
            // 
            // cbTipoCalculo
            // 
            cbTipoCalculo.FormattingEnabled = true;
            cbTipoCalculo.Items.AddRange(new object[] { "Somar", "Subtrair", "Multiplicar", "Dividir" });
            cbTipoCalculo.Location = new Point(155, 54);
            cbTipoCalculo.Name = "cbTipoCalculo";
            cbTipoCalculo.Size = new Size(121, 23);
            cbTipoCalculo.TabIndex = 4;
            cbTipoCalculo.SelectedIndexChanged += cbTipoCalculo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(54, 57);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo de Calculo :";
            label2.Click += label2_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(342, 95);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 7;
            label3.Text = "Resultado :";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = Color.Transparent;
            lbResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbResultado.ForeColor = Color.Red;
            lbResultado.Location = new Point(102, 131);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(25, 32);
            lbResultado.TabIndex = 8;
            lbResultado.Text = "?";
            // 
            // ListViewOp
            // 
            ListViewOp.Columns.AddRange(new ColumnHeader[] { Operação, Resultado });
            ListViewOp.Location = new Point(172, 131);
            ListViewOp.Name = "ListViewOp";
            ListViewOp.Size = new Size(244, 97);
            ListViewOp.TabIndex = 9;
            ListViewOp.UseCompatibleStateImageBehavior = false;
            ListViewOp.View = View.Details;
            // 
            // Operação
            // 
            Operação.Text = "Operação";
            Operação.Width = 150;
            // 
            // Resultado
            // 
            Resultado.Text = "Resultado";
            Resultado.Width = 90;
            // 
            // Calcularoda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(428, 245);
            Controls.Add(ListViewOp);
            Controls.Add(lbResultado);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(cbTipoCalculo);
            Controls.Add(LbSinal);
            Controls.Add(txtn2);
            Controls.Add(txtn1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calcularoda";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtn1;
        private TextBox txtn2;
        private Label LbSinal;
        private ComboBox cbTipoCalculo;
        private Label label2;
        private Button btnCalcular;
        private Label label3;
        private Label lbResultado;
        private ListView ListViewOp;
        private ColumnHeader Operação;
        private ColumnHeader Resultado;
    }
}