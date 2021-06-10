using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataprossingWeb.Models
{
    public class Int32Converter : System.Text.Json.Serialization.JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString();
                if (int.TryParse(stringValue, out int value))
                {
                    return value;
                }
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt32();
            }

            throw new System.Text.Json.JsonException();
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
    public class Repository
    {
        public static Task<List<PopulationAgeGroupInBaishaPenghu>> readData(string filename)
        {
            return Task.Run(() =>
            {
                string json = System.IO.File.ReadAllText(filename);
                var options = new JsonSerializerOptions();
                //options.Converters.Add(new JsonStringEnumConverter());
                options.Converters.Add(new Int32Converter());
                var dataSet = JsonSerializer.
                              Deserialize<List<PopulationAgeGroupInBaishaPenghu>>(json, options);
                return dataSet;
            });
        }
    }
}
