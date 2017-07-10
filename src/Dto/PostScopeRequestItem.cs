using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PostScopeRequestItem
    {
        [JsonProperty(PropertyName = "accessTypes")]
        public List<string> AccessTypes { get; set; }
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }

        public PostScopeRequestItem()
        {
            AccessTypes = new List<string>();
            ServiceName = string.Empty;
        }
    }
}
