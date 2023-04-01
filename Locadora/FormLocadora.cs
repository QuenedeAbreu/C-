namespace Locadora
{
    public partial class FormLocadora : Form
    {
        public FormLocadora()
        {
            InitializeComponent();
        }


        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
            
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui vai abrir os Carros!");
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui vai abrir os Alugueis");
        }
    }
}