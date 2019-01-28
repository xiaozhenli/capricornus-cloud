using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Capricornus.Cloud.Extensions.Nacos.Naming
{
    public class Instance : IEquatable<Instance>
    {
        public string InstanceId { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        public string ClusterName { get; set; }

        public string ServiceName { get; set; }

        public int Port { get; set; }

        public double Weight { get; set; }

        public bool Healthy { get; set; } = true;
        
        public bool Valid { get; set; }

        public bool Enabled { get; set; } = true;

        public Dictionary<string, string> Metadata { get; set; }

        public string GetIpAddress() => $"{Ip}:{Port}";

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Instance) obj);
        }

        public bool Equals(Instance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ToString() == other.ToString();
        }
    }
}