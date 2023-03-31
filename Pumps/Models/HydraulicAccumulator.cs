using System.ComponentModel.DataAnnotations.Schema;
namespace Pump.Models
{
    public class HydraulicAccumulator
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }
        public string? Typ { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
