using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ILivreRepository
    {
        IEnumerable<DalLivre> GetAll();

        int? Add(DalLivre newLivre);

        bool Update(DalLivre livre);
    }
}
