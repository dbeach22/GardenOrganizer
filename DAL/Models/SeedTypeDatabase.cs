
namespace DAL.Models
{
    public class SeedTypeDatabase
    {
        public SeedTypeDatabase()
        {
            Id = -1;
            Type = string.Empty;
        }

        public int Id { get; set; }

        public string Type { get; set; }
    }
}
