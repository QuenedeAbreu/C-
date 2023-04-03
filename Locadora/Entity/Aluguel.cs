using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Entity
{
    internal class Aluguel
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public int id_carro { get; set; }
        public string data_aluguel { get; set; }
        public string data_devolucao { get; set; }
        public Double valor_aluguel { get;set; }

        public Aluguel(int id_aluguel, int id_usuario, int id_carro, string data_aluguel, string data_devolucao, Double valor_aluguel) { 
        
        }
        public Aluguel( int id_usuario, int id_carro, string data_aluguel, string data_devolucao, Double valor_aluguel)
        {

        }

        public Aluguel() { 
        
        }
    }
}
