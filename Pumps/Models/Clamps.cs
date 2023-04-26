using System.ComponentModel.DataAnnotations.Schema;

namespace Pump.Models
{ 
    public class Clamp
    {
        
        public string Id { get; set; }
        public int ArtivendorСode { get; set; }
        public string? Title { get; set; }
        public int Diameter { get; set; }
        public decimal Price { get; set; }
        public string? Typ { get; set; }

        
    }
}
