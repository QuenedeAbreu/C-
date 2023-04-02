using Locadora.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.ClassDal
{
    internal class CarroDal
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public List<Carro> Listar()
        {
            cmd.CommandText = "SELECT * FROM carro";
            List<Carro> result = new();
            try
            {
                cmd.Connection = conexao.conectar();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Carro carro = new();
                    carro.Id = reader.IsDBNull(0) ? 000 : Convert.ToInt32(reader.GetInt64(0));
                    carro.Marca = reader.IsDBNull(1) ? "Sem Marca" : reader.GetString(1);
                    carro.Modelo = reader.IsDBNull(2) ? "Sem Modelo" : reader.GetString(2);
                    carro.Placa = reader.IsDBNull(3) ? "Sem Placa" : reader.GetString(3);
                    carro.Cor = reader.IsDBNull(4) ? "Sem Cor" : reader.GetString(4);
                    carro.Disponibilidade = reader.IsDBNull(5) ? 000 : Convert.ToInt32(reader.GetInt64(5));
                    result.Add(carro);

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
        public void Cadastrar(Carro carro)
        {
            cmd.CommandText = "INSERT INTO carro (marca_carro, modelo_carro,placa_carro,cor_carro,status_carro) values('" + carro.Marca + "','" +carro.Modelo + "','" +carro.Placa + "','" + carro.Cor + "','"+carro.Disponibilidade+"')";
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
                MessageBox.Show("Carro Inserido com sucesso!");
            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao inserir Carro : " + ex);
            }

        }
        public void Editar(Carro carro)
        {
            cmd.CommandText = "UPDATE carro set marca_carro = '" + carro.Marca + "', modelo_carro = '" + carro.Modelo + "',placa_carro = '" + carro.Placa + "',cor_carro = '" +carro.Cor + "',status_carro = '" + carro.Disponibilidade +"' where id_carro = '" + carro.Id + "'";
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
                MessageBox.Show("Carro editado com sucesso!");

            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Carro ao editar usuario : " + ex);
            }
        }
        public void Excluir(int Id)
        {
            cmd.CommandText = "DELETE FROM carro where id_carro = '" + Id + "'";
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Closed();
                MessageBox.Show("Carro deletado com sucesso!");

            }
            catch (Exception ex)
            {
                conexao.Closed();
                MessageBox.Show("Erro ao deletadar este carro : " + ex);
            }
        }
    }
}
