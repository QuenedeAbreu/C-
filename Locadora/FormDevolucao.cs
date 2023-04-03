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

namespace Locadora
{
    public partial class FormDevolucao : Form
    {
        CarroDal carro = new();
        LocacaoDal aluguel = new();
        public FormDevolucao()
        {
            InitializeComponent();
        }
        int id_carro = 0;
        int id_aluguel = 0;
        public FormDevolucao( int idAluguel,int idCarro)
        {
            InitializeComponent();
            id_carro = idCarro;
            id_aluguel = idAluguel;
        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {

        }

        public void DevolverCarro()
        {
            FormLocacao formLocacao = new();
            DateTime dataDataDevolver = DateTime.ParseExact(txtDataDevolver.Text, "dd/MM/yyyy", null);
            carro.TrocarStatusCarro(0, id_carro);
            aluguel.TrocarDataDevolucao(dataDataDevolver.ToString("yyyy-MM-dd"), id_aluguel);
            formLocacao.Show();
            formLocacao.popularListViewAluguel();
            formLocacao.PopularComboxCarro();
            MessageBox.Show("Carro devolvido com sucesso!");
            this.Close();

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            DevolverCarro();
        }
    }
}
