using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace Dataprossing
{
    static class Constants
    {
        public const string Filename = "/home/fuan/Projects/Dataprossing/Dataprossing/data (copy).json"; // Path to your JSON data
    }

    public class PopulationAgeGroupInBaishaPenghu
    {
        [JsonPropertyName("年度")]
        public string year { get; set; }
        [JsonPropertyName("月份")]
        public string month { get; set; }
        [JsonPropertyName("總計")]
        public string sum { get; set; }
        [JsonPropertyName("年齡：０-４歲")]
        public string age0 { get; set; }
        [JsonPropertyName("年齡：５-９歲")]
        public string age1 { get; set; }
        [JsonPropertyName("年齡：１０-１４歲")]
        public string age2 { get; set; }
        [JsonPropertyName("年齡：１５-１９歲")]
        public string age3 { get; set; }
        [JsonPropertyName("年齡：２０-２４歲")]
        public string age4 { get; set; }
        [JsonPropertyName("年齡：２５-２９歲")]
        public string age5 { get; set; }
        [JsonPropertyName("年齡：３５-３９歲")]
        public string age6 { get; set; }
        [JsonPropertyName("年齡：４０-４４歲")]
        public string age7 { get; set; }
        [JsonPropertyName("年齡：４５-４９歲")]
        public string age8 { get; set; }
        [JsonPropertyName("年齡：５０-５４歲")]
        public string age9 { get; set; }
        [JsonPropertyName("年齡：５５-５９歲")]
        public string age10 { get; set; }
        [JsonPropertyName("年齡：６０-６４歲")]
        public string age11 { get; set; }
        [JsonPropertyName("年齡：６５-６９歲")]
        public string age12 { get; set; }
        [JsonPropertyName("年齡：７０-７４歲")]
        public string age13 { get; set; }
        [JsonPropertyName("年齡：７５-７９歲")]
        public string age14 { get; set; }
        [JsonPropertyName("年齡：８０-８４歲")]
        public string age15 { get; set; }
        [JsonPropertyName("年齡：８５-８９歲")]
        public string age16 { get; set; }
        [JsonPropertyName("年齡：９０-９４歲")]
        public string age17 { get; set; }
        [JsonPropertyName("年齡：９５-９９歲")]
        public string age18 { get; set; }
        [JsonPropertyName("年齡：100歲以上")]
        public string age19 { get; set; }

        public PopulationAgeGroupInBaishaPenghu(string year, string month, string sum, string age0, string age1, string age2, string age3, string age4, string age5, string age6, string age7, string age8, string age9, string age10, string age11, string age12, string age13, string age14, string age15, string age16, string age17, string age18, string age19)
        {
            this.year = year;
            this.month = month;
            this.sum = sum;
            this.age0 = age0;
            this.age1 = age1;
            this.age2 = age2;
            this.age3 = age3;
            this.age4 = age4;
            this.age5 = age5;
            this.age6 = age6;
            this.age7 = age7;
            this.age8 = age8;
            this.age9 = age9;
            this.age10 = age10;
            this.age11 = age11;
            this.age12 = age12;
            this.age13 = age13;
            this.age14 = age14;
            this.age15 = age15;
            this.age16 = age16;
            this.age17 = age17;
            this.age18 = age18;
            this.age19 = age19;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("澎湖縣白沙鄉人口年齡層統計：");
            string json = System.IO.File.ReadAllText(Constants.Filename);
            //Console.WriteLine(json);
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            var dataSet = JsonSerializer.
                          Deserialize<List<PopulationAgeGroupInBaishaPenghu>>(json, options);
            var startingYear = Int32.Parse(dataSet[0].year);
            var endingYear = Int32.Parse(dataSet[dataSet.Count-1].year);

            Console.WriteLine("從民國{0}年到民國{1}年，共{2}年{3}比資料。",
                               startingYear,
                               endingYear,
                               endingYear - startingYear,
                               dataSet.Count);
        }
    }
}
