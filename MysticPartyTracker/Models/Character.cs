using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Character
    {
        public string Nome{ get; set; }
        public string Classe { get; set; }
        public string Raca { get; set; }
        public int Level { get; set; }

        public Character(string nome, string classe, string raca, int level)
        {
            Nome = nome;
            Classe = classe;
            Raca = raca;
            Level = level;
        }
    }
}
