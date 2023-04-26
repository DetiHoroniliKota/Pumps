using Pumps.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pump.Models
{
    public class Pump
    {
        
        public string Id { get; set; }

        public int ArtivendorСode { get; set; }

        public string? Title { get; set; }
   
        public int H { get; set; }

        public int Q { get; set; }

        public decimal Price { get; set; }

        public PumpTyp Typ { get; set; }

        public string? Picture { get; set; }

        
    }
}
