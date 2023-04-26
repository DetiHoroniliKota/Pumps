using System.ComponentModel.DataAnnotations.Schema;
namespace Pump.Models
{
    public class Cap
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public int ArtivendorСode { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Typ { get; set; }

        //public ICollection<Order> Equipments { get; set; }
    }
}
