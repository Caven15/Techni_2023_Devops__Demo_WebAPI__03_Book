using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class LivreDalRepository : ILivreRepository
    {
        private readonly List<DalLivre> _Livres;
        
        public LivreDalRepository()
        {
            _Livres = new List<DalLivre>()
            {
                new DalLivre(1,"OuiOui"),
                new DalLivre(2, "Seigneur des anneaux"),
                new DalLivre(3, "L'étranger")
            };
        }
        private int _Id = 3;

        public IEnumerable<DalLivre> GetAll()
        {
            return _Livres;
        }

        public int? Add(DalLivre data)
        {
            DalLivre newLivre = new DalLivre(_Id, data.Nom);

            _Livres.Add(newLivre);

            return newLivre.Id;
        }

        public bool Update(DalLivre livre)
        {
            DalLivre? livreExistant = _Livres.SingleOrDefault(l => l.Id == livre.Id);
            if (livreExistant is null)
            {
                return false;
            }

            livreExistant.Nom = livre.Nom;
            return true;
        }
    }
}
