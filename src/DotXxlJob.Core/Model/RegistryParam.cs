using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DotXxlJob.Core.Model
{
    [DataContract(Name = Constants.RegistryParamJavaFullName)]
    public class RegistryParam
    {
        [DataMember(Name = "registryGroup", Order = 1)]
        [JsonProperty("registryGroup")]
        [System.Text.Json.Serialization.JsonPropertyName("registryGroup")]
        public string RegistryGroup { get; set; }
        
        [DataMember(Name = "registryKey", Order = 2)]
        [JsonProperty("registryKey")]
        [System.Text.Json.Serialization.JsonPropertyName("registryKey")]
        public string RegistryKey { get; set; }
        
        
        [DataMember(Name = "registryValue", Order = 3)]
        [JsonProperty("registryValue")]
        [System.Text.Json.Serialization.JsonPropertyName("registryValue")]
        public string RegistryValue { get; set; }

    }
}