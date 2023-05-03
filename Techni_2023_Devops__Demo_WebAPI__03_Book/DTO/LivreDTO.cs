namespace Techni_2023_Devops__Demo_WebAPI__03_Book.DTO
{
    public class LivreDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public LivreDTO(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

    }

    public class LivreDataDTO
    {
        public string Nom { get; set; }
    }
}
