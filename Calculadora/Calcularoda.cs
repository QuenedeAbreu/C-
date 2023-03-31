namespace Calculadora
{
    public partial class Calcularoda : Form
    {
        public Calcularoda()
        {
            InitializeComponent();
        }

        Calculo calculo = new Calculo();
        private void calcular()
        {
            int calculoIndex = cbTipoCalculo.SelectedIndex;
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);

            Double result;
            if (calculoIndex == 0)
            {

                result = calculo.Somar(n1, n2);
                lbResultado.Text = result.ToString();
                PopularListView((n1.ToString() + " + " + n2.ToString()), result.ToString());

            }
            else if (calculoIndex == 1)
            {
                result = calculo.Subtrair(n1, n2);
                lbResultado.Text = result.ToString();
                PopularListView((n1.ToString() + " - " + n2.ToString()), result.ToString());
            }
            else if (calculoIndex == 2)
            {
                result = calculo.Multiplicar(n1, n2);
                lbResultado.Text = result.ToString();

                PopularListView((n1.ToString() + " x " + n2.ToString()), result.ToString());
            }
            else if (calculoIndex == 3)
            {
                result = calculo.Dividir(n1, n2);
                lbResultado.Text = Math.Round(result, 2).ToString();
                PopularListView((n1.ToString() + " / " + n2.ToString()), Math.Round(result, 2).ToString());
            }
            else
            {
                MessageBox.Show("Escolha uma operação!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void PopularListView(string calc, string result)
        {
            ListViewItem item = new ListViewItem(calc);
            item.SubItems.Add(result);

            ListViewOp.Items.Add(item);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int calculoIndex = cbTipoCalculo.SelectedIndex;
            if (calculoIndex == 0)
            {
                LbSinal.Text = "+";
            }
            else if (calculoIndex == 1)
            {
                LbSinal.Text = "-";
            }
            else if (calculoIndex == 2)
            {
                LbSinal.Text = "x";
            }
            else
            {

                LbSinal.Text = "/";
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}