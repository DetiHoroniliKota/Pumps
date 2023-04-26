using System.ComponentModel.DataAnnotations.Schema;
namespace Pump.Models
{
    public class Rope
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public int ArtivendorСode { get; set; }
        public string? Title { get; set; }
        public int Diameter { get; set; }
        public decimal Price { get; set; }

        //public ICollection<Order> Equipments{ get; set; }   
      
    }
}
