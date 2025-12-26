using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DotXxlJob.Core.Model
{
    
    [DataContract]
    public class TriggerParam
    {
        //static readonly long SerialVersionUID = 42L;

        [DataMember(Name = "jobId", Order = 1)]
        [JsonProperty("jobId")]
        [System.Text.Json.Serialization.JsonPropertyName("jobId")]
        public int JobId { get; set; }

        [DataMember(Name = "executorHandler", Order = 2)]
        [JsonProperty("executorHandler")]
        [System.Text.Json.Serialization.JsonPropertyName("executorHandler")]
        public string ExecutorHandler { get; set; }
        [DataMember(Name = "executorParams", Order = 3)]
        [JsonProperty("executorParams")]
        [System.Text.Json.Serialization.JsonPropertyName("executorParams")]
        public string ExecutorParams{ get; set; }
        
        [DataMember(Name = "executorBlockStrategy", Order = 4)]
        [JsonProperty("executorBlockStrategy")]
        [System.Text.Json.Serialization.JsonPropertyName("executorBlockStrategy")]
        public string ExecutorBlockStrategy{ get; set; }
        
        [DataMember(Name = "executorTimeout", Order = 5)]
        [JsonProperty("executorTimeout")]
        [System.Text.Json.Serialization.JsonPropertyName("executorTimeout")]
        public int ExecutorTimeout{ get; set; }
        
        [DataMember(Name = "logId",Order = 5)]
        [JsonProperty("logId")]
        [System.Text.Json.Serialization.JsonPropertyName("logId")]
        public long LogId { get; set; }
        [DataMember(Name = "logDateTime", Order = 6)]
        [JsonProperty("logDateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("logDateTime")]
        public long LogDateTime{ get; set; }
        

        [DataMember(Name = "glueType",Order = 7)]
        [JsonProperty("glueType")]
        [System.Text.Json.Serialization.JsonPropertyName("glueType")]
        public string GlueType{ get; set; }
        
        [DataMember(Name = "glueSource",Order = 8)]
        [JsonProperty("glueSource")]
        [System.Text.Json.Serialization.JsonPropertyName("glueSource")]
        public string GlueSource{ get; set; }
        
        [DataMember(Name = "glueUpdatetime", Order = 9)]
        [JsonProperty("glueUpdatetime")]
        [System.Text.Json.Serialization.JsonPropertyName("glueUpdatetime")]
        public long GlueUpdateTime{ get; set; }

        [DataMember(Name = "broadcastIndex",Order = 10)]
        [JsonProperty("broadcastIndex")]
        [System.Text.Json.Serialization.JsonPropertyName("broadcastIndex")]
        public int BroadcastIndex{ get; set; }
        [DataMember(Name = "broadcastTotal",Order = 11)]
        [JsonProperty("broadcastTotal")]
        [System.Text.Json.Serialization.JsonPropertyName("broadcastTotal")]
        public int BroadcastTotal{ get; set; }
    }
}