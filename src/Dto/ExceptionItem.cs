using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class ExceptionItem
    {
        [JsonProperty(PropertyName = "exception")]
        public string Exception { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        public ExceptionItem()
        {
            Exception = string.Empty;
            Message = string.Empty;
        }
    }
}
