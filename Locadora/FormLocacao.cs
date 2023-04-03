using Locadora.ClassDal;
using Locadora.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Locadora
{
    public partial class FormLocacao : Form
    {
        UserDal user = new();
        CarroDal carro = new();
        LocacaoDal aluguel = new();
        public FormLocacao()
        {

            InitializeComponent();
            PopularComboxUsuarios();
            PopularComboxCarro();
            popularListViewAluguel();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            if (btnProcessar.Text == "Processar")
            {
                Alugar();
            }
           



        }

        private void FormLocacao_Load(object sender, EventArgs e)
        {

        }

        public void PopularComboxUsuarios()
        {
            cbUsuario.Items.Clear();
            cbUsuario.DataSource = user.Listar();
            cbUsuario.DisplayMember = "Nome";
            cbUsuario.ValueMember = "id";
        }

        public void Alugar()
        {
            if (cbCarro.Items.Count > 0) { 
                if (cbCarro.Text == "" || cbUsuario.Text == "" || txtDataLocacao.Text == "" || txtValorDiaria.Text == "")
                {
                    MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        Aluguel alu = new();
                        DateTime dataLocacao = DateTime.ParseExact(txtDataLocacao.Text, "dd/MM/yyyy", null);

                        if (txtDevolucao.Text.Replace("/", " ").Equals(" "))
                        {
                      
                            DateTime dataDevolucao = DateTime.ParseExact(txtDevolucao.Text, "dd/MM/yyyy", null);
                            alu.data_devolucao = dataDevolucao.ToString("yyyy-MM-dd");
                        }
                        else
                        {

                            alu.data_devolucao = " ";

                        }

                        alu.id_usuario = Convert.ToInt32(cbUsuario.SelectedValue);
                        alu.id_carro = Convert.ToInt32(cbCarro.SelectedValue);
                        alu.data_aluguel = dataLocacao.ToString("yyyy-MM-dd");
                        alu.valor_aluguel = Convert.ToDouble(txtValorDiaria.Text);

                        aluguel.Cadastrar(alu);
                        carro.TrocarStatusCarro(1, alu.id_carro);
                        PopularComboxCarro();
                        popularListViewAluguel();
                        limparText();
                        MessageBox.Show("Carro alugado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao alugar o carrro!  - " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não temos carros disponíveis!");
            }
        }
        
        public void PopularComboxCarro()
        {
            cbCarro.DataSource = null;
            cbCarro.Items.Clear();
            List<Carro> carros = new List<Carro>();
            // So vai adcionar no combox os carros disponiveis
            foreach (Carro car in carro.Listar())
            {
                if (car.Disponibilidade == 0)
                {
                    carros.Add(car);
                }
            }
            cbCarro.DataSource = carros;
            cbCarro.DisplayMember = "Modelo";
            cbCarro.ValueMember = "id";
        }

        public void popularListViewAluguel()
        {

            /* Usuario OneUsuario = user.ListarOne()[0];
             Carro oneCarro = carro.ListarOne()[0];*/

            listAlugel.Items.Clear();
            List<Aluguel> alu = aluguel.Listar();
            foreach (var item in alu)
            {
                var valorPago = "";
                int totalDias = 1;

                if (item.data_aluguel != "Sem Data de Aluguel" && item.data_devolucao != "Sem Data de devolução")
                {
                    totalDias = (DateTime.Parse(item.data_devolucao).Subtract(DateTime.Parse(item.data_aluguel))).Days;
                    if (totalDias == 0)
                    {
                        totalDias = 1;
                    }
                    Double calc = item.valor_aluguel * totalDias;
                    valorPago = calc.ToString();
                }
                else
                {
                    valorPago = "-";

                }
                Usuario oneUsuario = user.ListarOne(item.id_usuario)[0];
                Carro oneCarro = carro.ListarOne(item.id_carro)[0];
                listAlugel.Items.Add(new ListViewItem(new string[] { Convert.ToString(item.id), oneCarro.Modelo, oneCarro.Placa, oneUsuario.Nome, item.data_aluguel, item.data_devolucao, item.valor_aluguel.ToString(), totalDias.ToString(), valorPago }));
            }
        }


        public void limparText()
        {
            cbUsuario.SelectedIndex = 0;
            cbCarro.SelectedIndex = 0;
            txtValorDiaria.Text = "";
            txtDataLocacao.Text = "";
            txtDevolucao.Text = "";
            btnProcessar.Text = "Processar";
        }

        private void listAlugel_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listAlugel.SelectedItems.Count == 0)
                return;
            if (!listAlugel.SelectedItems[0].SubItems[5].Text.ToString().Equals("Sem Data de devolução"))
            {
                menuLocacao.Enabled = false;
                devolverCarro.Text = "Carro Devolvido";
            }
            else
            {
                menuLocacao.Enabled = true;
                devolverCarro.Text = "Devolver Carro";
            }

        }

        private void devolverCarro_Click(object sender, EventArgs e)
        {
             int idAluguel = Convert.ToInt32( listAlugel.SelectedItems[0].SubItems[0].Text);
             Aluguel alu  = aluguel.ListarOne(idAluguel)[0];
          
            FormDevolucao formDevolucao = new(alu.id,alu.id_carro);
            this.Close();
            formDevolucao.Show();
            
        }
    }
}
