using Locadora.ClassDal;
using Locadora.Entity;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace Locadora
{
    public partial class FormCarro : Form
    {
        CarroDal carroDal = new();

        public FormCarro()
        {
            InitializeComponent();
        }

        private void FormCarro_Load(object sender, EventArgs e)
        {
            popularListViewCarro();
            btnCancelar.Enabled = false;
            ckDis.Checked = true;
        }

        public void popularListViewCarro()
        {
            listCarros.Items.Clear();
            List<Carro> users = carroDal.Listar();
            var dis = "";
            foreach (var item in users)
            {
                if (item.Disponibilidade == 0)
                {
                    dis = "Disponivel";

                }
                else
                {
                    dis = "Alugado";
                }
                listCarros.Items.Add(new ListViewItem(new string[] { Convert.ToString(item.Id), item.Marca, item.Modelo, item.Placa, item.Cor, dis }));

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
            {
                CadastrarCarro();
            }
            else
            {
                EditarCarro();
            }

        }

        public void CadastrarCarro()
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtPlaca.Text == "" || txtCor.Text == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Carro carro = new();
                    carro.Marca = txtMarca.Text;
                    carro.Modelo = txtModelo.Text;
                    carro.Placa = txtPlaca.Text;
                    carro.Cor = txtCor.Text;
                    carro.Disponibilidade = ckDis.Checked ? 0 : 1;
                    carroDal.Cadastrar(carro);
                    popularListViewCarro();
                    limparText();
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar o Usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        public void EditarCarro()
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtCor.Text == "" || txtPlaca.Text == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var id = listCarros.SelectedItems[0].SubItems[0].Text;
                try
                {

                    Carro carro = new();
                    carro.Id = Convert.ToInt16(id);
                    carro.Marca = txtMarca.Text;
                    carro.Modelo = txtModelo.Text;
                    carro.Placa = txtPlaca.Text;
                    carro.Cor = txtCor.Text;
                    carro.Disponibilidade = ckDis.Checked ? 0 : 1;
                    carroDal.Editar(carro);
                    popularListViewCarro();
                    limparText();
                    btnCancelar.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Erro ao editar o Usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void limparText()
        {

            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtCor.Text = "";
            btnSalvar.Text = "Salvar";
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMarca.Text = listCarros.SelectedItems[0].SubItems[1].Text;
            txtModelo.Text = listCarros.SelectedItems[0].SubItems[2].Text;
            txtPlaca.Text = listCarros.SelectedItems[0].SubItems[3].Text;
            txtCor.Text = listCarros.SelectedItems[0].SubItems[4].Text;

            btnSalvar.Text = "Editar";
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparText();
            btnCancelar.Enabled = false;

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string modelo = listCarros.SelectedItems[0].SubItems[2].Text;
            DialogResult result = MessageBox.Show("Deseja realmente excluir o carro do modelo : " + modelo, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var id = listCarros.SelectedItems[0].SubItems[0].Text;
                carroDal.Excluir(Convert.ToInt32(id));
                popularListViewCarro();
            }
        }
    }
}
