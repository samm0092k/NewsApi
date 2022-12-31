using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace NewsApi.Constants
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Categories
    {
        Business,
        Entertainment,
        Health,
        Science,
        Sports,
        Technology
    }
}
