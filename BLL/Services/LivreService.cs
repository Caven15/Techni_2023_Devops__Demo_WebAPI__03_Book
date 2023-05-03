using BLL.Interfaces;
using BLL.Mapper;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LivreService : ILivreService
    {
        // variables concernant l'utilisation du repository de la dal
        private readonly ILivreRepository _livreRepository;

        // Injection du service de la dal via constructeur
        public LivreService(ILivreRepository livreRepository)
        {
            _livreRepository = livreRepository;
        }

        public int? Add(Livre newLivre)
        {
            return _livreRepository.Add(newLivre.ToDal());
        }

        public IEnumerable<Livre> GettAll()
        {
            return _livreRepository.GetAll().Select(l => l.ToBll());
        }

        public bool Update(int id, Livre livre)
        {
            livre.Id = id;
            return _livreRepository.Update(livre.ToDal());
        }
    }
}
