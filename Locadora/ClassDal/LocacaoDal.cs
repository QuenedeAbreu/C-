using Locadora.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.ClassDal
{
    internal class LocacaoDal
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public List<Aluguel> Listar()
        {
            cmd.CommandText = "SELECT * FROM aluguel ORDER BY data_devolucao";
            List<Aluguel> result = new();
            try
            {
                cmd.Connection = conexao.conectar();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Aluguel Aluguel = new();
                    Aluguel.id = reader.IsDBNull(0) ? 000 : reader.GetInt32(0);
                    Aluguel.id_usuario = reader.IsDBNull(1) ? 000 : reader.GetInt32(1);
                    Aluguel.id_carro = reader.IsDBNull(2) ? 000 : reader.GetInt32(2);
                    Aluguel.data_aluguel = reader.IsDBNull(3) ? "Sem Data de Aluguel" : reader.GetString(3);
                    Aluguel.data_devolucao = reader.IsDBNull(4) ? "Sem Data de devolução" : reader.GetString(4);
                    Aluguel.valor_aluguel = reader.IsDBNull(5) ? 000 : Convert.ToInt32(reader.GetInt64(5));
                    result.Add(Aluguel);

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


        public void Cadastrar(Aluguel aluguel)
        {
           /* MessageBox.Show(aluguel.data_devolucao);*/
            if (aluguel.data_devolucao.Equals(" "))
            {
            cmd.CommandText = "INSERT INTO aluguel (id_usuario, id_carro,data_aluguel,valor_aluguel) values('" + aluguel.id_usuario + "','" + aluguel.id_carro + "','" + aluguel.data_aluguel + "','" + aluguel.valor_aluguel + "')";
            }
            else { 
            
            cmd.CommandText = "INSERT INTO aluguel (id_usuario, id_carro,data_aluguel,data_devolucao,valor_aluguel) values('" + aluguel.id_usuario + "','" + aluguel.id_carro + "','" + aluguel.data_aluguel + "','" + aluguel.data_devolucao + "','" + aluguel.valor_aluguel + "')";
            }
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
               
            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao alugar o carro : " + ex);
            }

        }
        public void TrocarDataDevolucao(string dataDevolucao, int IdAlugeul)
        {
            cmd.CommandText = "UPDATE aluguel SET data_devolucao = '"+dataDevolucao+"' where id_aluguel = '"+ IdAlugeul + "'";
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
               

            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao devolver o carro : " + ex);
            }
        }


        public List<Aluguel> ListarOne(int idAluguel)
        {
            cmd.CommandText = "SELECT * FROM aluguel where id_aluguel = '"+idAluguel+"'";
            List<Aluguel> result = new();
            try
            {
                cmd.Connection = conexao.conectar();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Aluguel Aluguel = new();
                    Aluguel.id = reader.IsDBNull(0) ? 000 : reader.GetInt32(0);
                    Aluguel.id_usuario = reader.IsDBNull(1) ? 000 : reader.GetInt32(1);
                    Aluguel.id_carro = reader.IsDBNull(2) ? 000 : reader.GetInt32(2);
                    Aluguel.data_aluguel = reader.IsDBNull(3) ? "Sem Data de Aluguel" : reader.GetString(3);
                    Aluguel.data_devolucao = reader.IsDBNull(4) ? "Sem Data de devolução" : reader.GetString(4);
                    Aluguel.valor_aluguel = reader.IsDBNull(5) ? 000 : Convert.ToInt32(reader.GetInt64(5));
                    result.Add(Aluguel);

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
    }
}
