using Dataprossing;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dataprossing
{
    static class Constants
    {
        public const string Filename = "data.json"; // Path to your JSON data
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("澎湖縣白沙鄉人口年齡層統計：");
            //string json = System.IO.File.ReadAllText(Constants.Filename);
            //Console.WriteLine(json);
            //var options = new JsonSerializerOptions();
            //options.Converters.Add(new JsonStringEnumConverter());
            var dataSet = Repository.readData(Constants.Filename);
            var startingYear = Int32.Parse(dataSet[0].year);
            var endingYear = Int32.Parse(dataSet[dataSet.Count - 1].year);

            Console.WriteLine("從民國{0}年到民國{1}年，共{2}年{3}比資料。",
                               startingYear,
                               endingYear,
                               endingYear - startingYear,
                               dataSet.Count);
        }
    }
}
