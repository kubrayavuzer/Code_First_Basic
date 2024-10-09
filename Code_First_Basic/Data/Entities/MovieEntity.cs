using CodeFirstBasic.Entities;

namespace Code_First_Basic.Data.Entities
{
    public class MovieEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

    }
}
