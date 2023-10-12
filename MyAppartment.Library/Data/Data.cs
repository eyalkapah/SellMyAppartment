using System.Text.Json.Serialization;

namespace MyAppartment.Library.Data;
public class UserData
{
    [JsonPropertyName("main")]
    public Main Main { get; set; }

    [JsonPropertyName("top_summary")]
    public TopSummary TopSummary { get; set; }

    [JsonPropertyName("price")]
    public Price Price { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("details")]
    public string[] Details { get; set; }

    [JsonPropertyName("additional_data")]
    public string[] AdditionalData { get; set; }

    [JsonPropertyName("images")]
    public Image[] Images { get; set; }
}

public class Image
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}

public class Main
{
    [JsonPropertyName("street_name")]
    public string StreetName { get; set; }

    [JsonPropertyName("neighborhood")]
    public string Neighborhood { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }
}

public class Price
{
    [JsonPropertyName("value")]
    public long Value { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }
}

public class TopSummary
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("rooms")]
    public long Rooms { get; set; }

    [JsonPropertyName("floor")]
    public string Floor { get; set; }

    [JsonPropertyName("size")]
    public string Size { get; set; }

    [JsonPropertyName("extra")]
    public string[] Extra { get; set; }
}