using Google.Protobuf;
using Locadora.ClassDal;
using Locadora.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class FormUsuario : Form
    {
        UserDal userDal = new();
        
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            //Funcao para popular list view
            popularListViewUsuario();
        }

        public void popularListViewUsuario()
        {
            listUsuarios.Items.Clear();
            List<Usuario> users = userDal.Listar();
            userDal.Listar();
            foreach (var item in userDal.Listar())
            {
                listUsuarios.Items.Add(new ListViewItem(new string[] { Convert.ToString(item.Id), item.Nome, item.DataNascimento, item.Email, item.Cpf }));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
            {
                CadastrarUser();
            }
            else
            {
                EditarUser();
            }



        }

        private void Editar_Click(object sender, EventArgs e)
        {
            txtNome.Text = listUsuarios.SelectedItems[0].SubItems[1].Text;
            txtData.Text = listUsuarios.SelectedItems[0].SubItems[2].Text;
            txtEmail.Text = listUsuarios.SelectedItems[0].SubItems[3].Text;
            txtCpf.Text = listUsuarios.SelectedItems[0].SubItems[4].Text;
            btnSalvar.Text = "Editar";
            btnCancelar.Enabled = true;
        }

        public void CadastrarUser()
        {
            if (txtNome.Text == "" || txtData.Text == "" || txtEmail.Text == "" || txtCpf.Text == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    DateTime data = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", null);
                    Usuario usuario = new();
                    usuario.Nome = txtNome.Text;
                    usuario.DataNascimento = data.ToString("yyyy-MM-dd");
                    usuario.Email = txtEmail.Text;
                    usuario.Cpf = txtCpf.Text.Replace(",", ".");
                    userDal.Cadastrar(usuario);
                    popularListViewUsuario();
                    limparText();
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar o Usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void EditarUser()
        {
            Usuario user = new();

            if (txtNome.Text == "" || txtData.Text == "" || txtEmail.Text == "" || txtCpf.Text == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var id = listUsuarios.SelectedItems[0].SubItems[0].Text;
                try
                {
                    DateTime data = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", null);
                    user.Id = Convert.ToInt16(id);
                    user.Nome = txtNome.Text;
                    user.DataNascimento = data.ToString("yyyy-MM-dd");
                    user.Email = txtEmail.Text;
                    user.Cpf = txtCpf.Text.Replace(",", ".");

                    userDal.Editar(user);
                    popularListViewUsuario();
                    limparText();
                }
                catch
                {
                    MessageBox.Show("Erro ao editar o Usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            string nome = listUsuarios.SelectedItems[0].SubItems[1].Text;
            DialogResult result = MessageBox.Show("Deseja realmente excluir o usuario : " + nome, "Atenção",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var id = listUsuarios.SelectedItems[0].SubItems[0].Text;
                userDal.Excluir(Convert.ToInt32(id));
                popularListViewUsuario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparText();
            btnCancelar.Enabled = false;
        }

        public void limparText()
        {
            txtNome.Text = "";
            txtData.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            btnSalvar.Text = "Salvar";

        }
    }
}
