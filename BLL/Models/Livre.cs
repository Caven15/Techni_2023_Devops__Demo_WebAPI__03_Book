using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Livre
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public Livre(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}
