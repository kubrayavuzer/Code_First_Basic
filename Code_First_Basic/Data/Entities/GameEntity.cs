using CodeFirstBasic.Entities;
using System.ComponentModel.DataAnnotations;

namespace Code_First_Basic.Data.Entities
{
    public class GameEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }

        [Range(0,10)]
        public decimal Rating { get; set; }
    }
}
