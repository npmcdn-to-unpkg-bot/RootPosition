﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Root.Analytics.Models
{
    [DataContract]
    public class StatsServicesOptions
    {
        [DataMember(Name = "serviceRoot")]
        public string ServiceRoot;

        [DataMember(Name = "getStatsViewDataMethod")]
        public string GetStatsViewDataMethod;

        [DataMember(Name = "getGraphViewDataMethod")]
        public string GetGraphViewDataMethod;

        [DataMember(Name = "getMapViewDataMethod")]
        public string GetMapViewDataMethod;

        [DataMember(Name = "getChoroplethViewDataMethod")]
        public string GetChoroplethViewDataMethod;

        private Dictionary<string, string> _parameters;

        [DataMember(Name = "parameters")]
        public Dictionary<string, string> Parameters
        {
            get
            {
                return _parameters ?? (_parameters = new Dictionary<string, string>());
            }
        }

    }
}
