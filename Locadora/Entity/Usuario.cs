using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Entity
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }


        public Usuario(int id, string nome, string DataNascimento, string email, string cpf) { 
            this.Id = id;
            this.Nome = nome;
            this.DataNascimento = DataNascimento;
            this.Email = email;
            this.Cpf = cpf;
        }

        public Usuario(string nome, string DataNascimento, string email, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = DataNascimento;
            this.Email = email;
            this.Cpf = cpf;
        }
        public Usuario()
        {
          
        }

      

    }
}
