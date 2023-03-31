using System;
using System.Collections.Generic;

namespace WebPumpMVC.Models
{
    public class Pump
    {
        public int Id { get; set; }

       
        public string Title { get; set; }

        
        public DateTime ReleaseDate { get; set; }
       
       
        public int H { get; set; }

       
        public int Q { get; set; }

        
        public decimal Price { get; set; }
        public string Typ { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
