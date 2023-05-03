using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    internal static class Mappers
    {
        internal static Livre ToBll(this DalLivre model)
        {
            return new Livre(model.Id, model.Nom);
        }

        internal static DalLivre ToDal(this Livre model)
        {
            return new DalLivre(model.Id, model.Nom);
        }
    }
}
