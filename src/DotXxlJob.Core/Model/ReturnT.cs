using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Text.Json;
namespace DotXxlJob.Core
{
    [DataContract(Name = Constants.ReturnTJavaFullName)]
    public class ReturnT
    {
        public const int SUCCESS_CODE = 200;
        public const int FAIL_CODE = 500;

        public static readonly ReturnT SUCCESS = new ReturnT(SUCCESS_CODE, null);
        public static readonly ReturnT FAIL = new ReturnT(FAIL_CODE, null);
        public static readonly ReturnT FAIL_TIMEOUT = new ReturnT(502, null);

        public ReturnT() { }

        public ReturnT(int code, string msg)
        {
            Code = code;
            Msg = msg;
        }


        [DataMember(Name = "code", Order = 1)]
        [JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public int Code { get; set; }
        [DataMember(Name = "msg", Order = 2)]
        [JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string Msg { get; set; }

        [DataMember(Name = "content", Order = 3)]
        [JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public object Content { get; set; }
        [DataMember(Name = "data", Order = 4)]
        [JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public object Data { get; set; }



        public static ReturnT Failed(string msg)
        {
            return new ReturnT(FAIL_CODE, msg);
        }
        public static ReturnT Success(string msg)
        {
            return new ReturnT(SUCCESS_CODE, msg);
        }

    }



}