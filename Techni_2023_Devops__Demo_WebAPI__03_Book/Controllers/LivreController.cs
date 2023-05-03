using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Techni_2023_Devops__Demo_WebAPI__03_Book.DTO;
using Techni_2023_Devops__Demo_WebAPI__03_Book.DTO.Mappers;

namespace Techni_2023_Devops__Demo_WebAPI__03_Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivreController : Controller
    {
        // variables concernant l'utilisation du service de la bll
        private readonly ILivreService _LivreService;

        // injection du service dans le controller via constructeur
        public LivreController(ILivreService livreController)
        {
            _LivreService = livreController;
        }

        // GetAll
        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<LivreDTO> livres = _LivreService.GettAll().Select(l => l.ToDTO());
            return Ok(livres);
        }

        [HttpPost]
        public IActionResult Add(LivreDataDTO dataDTO)
        {
            int? Livre = _LivreService.Add(dataDTO.ToModel());

            return Ok("Livre :" + dataDTO.Nom + " à été ajouter avec succès !");
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] LivreDTO dataDTO)
        {
            if (_LivreService.Update(id, new Livre(dataDTO.Id,dataDTO.Nom)))
            {
                return Ok("Livre Mis a jour avec succès !");
            }

            return NotFound();
        }
    }
}
