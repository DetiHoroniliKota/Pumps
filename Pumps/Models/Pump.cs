using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pump.Models
{
    public class Pump
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        public string? Title { get; set; }

        
        public DateTime ReleaseDate { get; set; }
       
        
        public int H { get; set; }

        
        public int Q { get; set; }

        
        public decimal Price { get; set; }
        public string? Typ { get; set; }
        public string? Picture { get; set; }

        public ICollection<Equipment>? Equipments { get; set; }
    }
}
