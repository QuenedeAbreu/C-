namespace Locadora
{
    partial class FormDevolucao
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
            label5 = new Label();
            txtDataDevolver = new MaskedTextBox();
            btnDevolver = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(118, 9);
            label5.Name = "label5";
            label5.Size = new Size(162, 40);
            label5.TabIndex = 15;
            label5.Text = "Devolução";
            // 
            // txtDataDevolver
            // 
            txtDataDevolver.Location = new Point(138, 88);
            txtDataDevolver.Mask = "00/00/0000";
            txtDataDevolver.Name = "txtDataDevolver";
            txtDataDevolver.Size = new Size(120, 23);
            txtDataDevolver.TabIndex = 16;
            txtDataDevolver.ValidatingType = typeof(DateTime);
            // 
            // btnDevolver
            // 
            btnDevolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDevolver.Location = new Point(138, 134);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(120, 45);
            btnDevolver.TabIndex = 17;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // FormDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 225);
            Controls.Add(btnDevolver);
            Controls.Add(txtDataDevolver);
            Controls.Add(label5);
            Name = "FormDevolucao";
            Text = "FormDevolucao";
            Load += FormDevolucao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private MaskedTextBox txtDataDevolver;
        private Button btnDevolver;
    }
}