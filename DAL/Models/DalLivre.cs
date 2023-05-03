using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DalLivre
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public DalLivre(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}
