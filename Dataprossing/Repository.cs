using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dataprossing
{
    public class Repository
    {
        public static List<PopulationAgeGroupInBaishaPenghu> readData(string filename)
        {
            string json = System.IO.File.ReadAllText(filename);
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            var dataSet = JsonSerializer.
                          Deserialize<List<PopulationAgeGroupInBaishaPenghu>>(json, options);

            return dataSet;
        }
    }
}
