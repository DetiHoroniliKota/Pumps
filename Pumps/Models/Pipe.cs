using System.ComponentModel.DataAnnotations.Schema;
namespace Pump.Models
{
    public class Pipe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Diameter { get; set; }
        public decimal Price { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
