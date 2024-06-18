using System.ComponentModel.DataAnnotations.Schema;

namespace Task15.Models.Entities
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }
}
