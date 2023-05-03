using BLL.Models;

namespace Techni_2023_Devops__Demo_WebAPI__03_Book.DTO.Mappers
{
    public static class LivreMapper
    {
        public static LivreDTO ToDTO(this Livre model)
        {
            return new LivreDTO(model.Id, model.Nom);
        }

        public static Livre ToModel(this LivreDataDTO data)
        {
            return new Livre(-1, data.Nom);
        }
    }
}
