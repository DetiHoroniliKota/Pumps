using System.ComponentModel.DataAnnotations.Schema;

namespace Pump.Models
{ 
    public class Order
    {
        
        public string Id { get; set; }
        //public int PumpId { get; set; }
        //public int RopeId { get; set; }
        //public int HydraulicAccumulatorId { get; set; }
        //public int ClampId { get; set; }
        //public int PipeId { get; set; }
        //public int CapId { get; set; }
        //public int UnderwaterСableId { get; set; }
        //public int AutomationId { get; set; }
        

        public Automation Automation { get; set; }
        public UnderwaterСable UnderwaterСable { get; set; }
        public Cap Cap { get; set; }
        public Pipe Pipe { get; set; }
        public Clamp Clamp { get; set; }
        public HydraulicAccumulator HydraulicAccumulator { get; set; }
        public Pump Pump { get; set; }
        public Rope Rope { get; set; }
        public decimal Total => Pump.Price + Rope.Price + HydraulicAccumulator.Price + Clamp.Price + UnderwaterСable.Price + Automation.Price;
    }
}
