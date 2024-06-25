using System.Text.Json.Serialization;

namespace SeptaMap.Infrastructure.External.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
    public class TrainViewDTO
    { 
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        [JsonPropertyName("trainno")]
        public string TrainNo { get; set; }

        [JsonPropertyName("service")]
        public string Service { get; set; }

        [JsonPropertyName("dest")]
        public string Dest { get; set; }

        [JsonPropertyName("currentstop")]
        public string CurrentStop { get; set; }

        [JsonPropertyName("nextstop")]
        public string NextStop { get; set; }

        [JsonPropertyName("line")]
        public string Line { get; set; }

        [JsonPropertyName("consist")]
        public string Consist { get; set; }

        [JsonPropertyName("heading")]
        public string Heading { get; set; }

        [JsonPropertyName("late")]
        public int Late { get; set; }

        [JsonPropertyName("SOURCE")]
        public string Source { get; set; }

        [JsonPropertyName("TRACK")]
        public string Track { get; set; }

        [JsonPropertyName("TRACK_CHANGE")]
        public string Track_Change { get; set; }
    }
}
