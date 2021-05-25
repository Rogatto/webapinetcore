using System.Text.Json.Serialization;

namespace Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}
