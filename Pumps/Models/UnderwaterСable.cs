using System.ComponentModel.DataAnnotations.Schema;
namespace Pump.Models
{
    public class UnderwaterСable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public double Section { get; set; }
        public decimal Price { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
