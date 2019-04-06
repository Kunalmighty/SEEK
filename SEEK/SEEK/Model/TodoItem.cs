using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEEK.Model
{
    public class TodoItem
    {
        public string Id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string version { get; set; }
        public bool deleted { get; set; }
    
        public string Name { get; set; }
        public string Brand { get; set; }
        public string ScreenSize { get; set; }
        public string DisplayType { get; set; }
        public string DisplayResolution { get; set; }
        public string OS { get; set; }
        public string RAM { get; set; }
        public string PriceNew { get; set; }
        public string PriceUsed { get; set; }

        public string PerformanceTier { get; set; }
        public string CameraPerformanceTier { get; set; }
        public string BatteryTier { get; set; }
        public string FingerprintScanner { get; set; }
        public string BestPurchase { get; set; }

        public string NewRelease { get; set; }

    }
}
