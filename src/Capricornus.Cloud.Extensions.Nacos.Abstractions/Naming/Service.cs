using System.Collections.Generic;

namespace Capricornus.Cloud.Extensions.Nacos.Naming
{
    public class Service
    {
        public string Name { get; set; }

        public float ProtectThreshold { get; set; }

        public string App { get; set; }

        public string Group { get; set; }
        
        public string HealthCheckMode { get; set; }
        
        public Dictionary<string, string> Metadata { get; set; }
        
        
    }
}