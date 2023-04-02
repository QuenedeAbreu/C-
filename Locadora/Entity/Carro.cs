using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Entity
{
    internal class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int Disponibilidade { get; set; }
        public Carro(int Id , string Marca, string Modelo, string Placa, string Cor, int Disponibilidade) { 
            this.Id = Id;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Cor = Cor;
            this.Disponibilidade = Disponibilidade;
        }
        public Carro( string Marca, string Modelo, string Placa, string Cor, int Disponibilidade)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Cor = Cor;
            this.Disponibilidade = Disponibilidade;
        }

        public Carro()
        {

        }
    }
}
