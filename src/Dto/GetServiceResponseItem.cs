using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetServiceResponseItem
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        [JsonProperty(PropertyName = "scopable")]
        public bool Scopable { get; set; }

        public GetServiceResponseItem()
        {
            Description = string.Empty;
            Path = string.Empty;
        }
    }
}
