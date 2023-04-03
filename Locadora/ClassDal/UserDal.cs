using Locadora.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Locadora.ClassDal
{
    internal class UserDal
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();


        public void Cadastrar(Usuario user)
        {
            cmd.CommandText = "INSERT INTO usuario (nome_usuario, data_nascimento_usuario,email_usuario,cpf_usuario) values('" + user.Nome + "','" + user.DataNascimento + "','" + user.Email + "','" + user.Cpf + "')";
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
          

            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao inserir usuario : " + ex);
            }
        }


        public List<Usuario> Listar()
        {
            cmd.CommandText = "SELECT * FROM usuario";
            List<Usuario> result = new();
            try
            {
                cmd.Connection = conexao.conectar();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Usuario user = new();
                    user.Id = reader.IsDBNull(0) ? 000 : Convert.ToInt32(reader.GetInt64(0));
                    user.Nome = reader.IsDBNull(1) ? "Sem nome" : reader.GetString(1);
                    user.DataNascimento = reader.IsDBNull(2) ? "Sem Data de Nascimento" : reader.GetString(2);
                    user.Email = reader.IsDBNull(3) ? "Sem Email" : reader.GetString(3);
                    user.Cpf = reader.IsDBNull(4) ? "Sem Cpf" : reader.GetString(4);
                    result.Add(user);

                }

                conexao.Closed();

                return result;
            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao listar os resultados : " + ex);

                return result;
            }

        }

        public List<Usuario> ListarOne(int id)
        {
            cmd.CommandText = "SELECT * FROM usuario where id_usuario = '"+id+"'";
            List<Usuario> result = new();
            try
            {
                cmd.Connection = conexao.conectar();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Usuario user = new();
                    user.Id = reader.IsDBNull(0) ? 000 : Convert.ToInt32(reader.GetInt64(0));
                    user.Nome = reader.IsDBNull(1) ? "Sem nome" : reader.GetString(1);
                    user.DataNascimento = reader.IsDBNull(2) ? "Sem Data de Nascimento" : reader.GetString(2);
                    user.Email = reader.IsDBNull(3) ? "Sem Email" : reader.GetString(3);
                    user.Cpf = reader.IsDBNull(4) ? "Sem Cpf" : reader.GetString(4);
                    result.Add(user);

                }

                conexao.Closed();

                return result;
            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao listar os resultados : " + ex);

                return result;
            }

        }

        public void Editar(Usuario user)
        {
            cmd.CommandText = "UPDATE usuario set nome_usuario = '" + user.Nome + "', data_nascimento_usuario = '" + user.DataNascimento + "',email_usuario = '" + user.Email + "',cpf_usuario = '" + user.Cpf + "' where id_usuario = '" + user.Id + "'";
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
                MessageBox.Show("Usuario editado com sucesso!");

            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao editar usuario : " + ex);
            }
        }

        public void Excluir(int Id) {
            cmd.CommandText = "DELETE FROM usuario where id_usuario = '" + Id + "'";
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
                MessageBox.Show("Usuario Deletado com sucesso!");

            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao deletadar usuario : " + ex);
            }
        }
    }
}
