using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

using System.ComponentModel.DataAnnotations.Schema;

namespace Dataprossing.Models
{
    public class PopulationAgeGroupInBaishaPenghu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [JsonPropertyName("年度")]
        public int year { get; set; }
        [JsonPropertyName("月份")]
        public int month { get; set; }
        [JsonPropertyName("總計")]
        public int sum { get; set; }
        [JsonPropertyName("年齡：０-４歲")]
        public int age0 { get; set; }
        [JsonPropertyName("年齡：５-９歲")]
        public int age1 { get; set; }
        [JsonPropertyName("年齡：１０-１４歲")]
        public int age2 { get; set; }
        [JsonPropertyName("年齡：１５-１９歲")]
        public int age3 { get; set; }
        [JsonPropertyName("年齡：２０-２４歲")]
        public int age4 { get; set; }
        [JsonPropertyName("年齡：２５-２９歲")]
        public int age5 { get; set; }
        [JsonPropertyName("年齡：３５-３９歲")]
        public int age6 { get; set; }
        [JsonPropertyName("年齡：４０-４４歲")]
        public int age7 { get; set; }
        [JsonPropertyName("年齡：４５-４９歲")]
        public int age8 { get; set; }
        [JsonPropertyName("年齡：５０-５４歲")]
        public int age9 { get; set; }
        [JsonPropertyName("年齡：５５-５９歲")]
        public int age10 { get; set; }
        [JsonPropertyName("年齡：６０-６４歲")]
        public int age11 { get; set; }
        [JsonPropertyName("年齡：６５-６９歲")]
        public int age12 { get; set; }
        [JsonPropertyName("年齡：７０-７４歲")]
        public int age13 { get; set; }
        [JsonPropertyName("年齡：７５-７９歲")]
        public int age14 { get; set; }
        [JsonPropertyName("年齡：８０-８４歲")]
        public int age15 { get; set; }
        [JsonPropertyName("年齡：８５-８９歲")]
        public int age16 { get; set; }
        [JsonPropertyName("年齡：９０-９４歲")]
        public int age17 { get; set; }
        [JsonPropertyName("年齡：９５-９９歲")]
        public int age18 { get; set; }
        [JsonPropertyName("年齡：100歲以上")]
        public int age19 { get; set; }

        public PopulationAgeGroupInBaishaPenghu()
        {

        }

        public PopulationAgeGroupInBaishaPenghu(int id, int year, int month, int sum, int age0, int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8, int age9, int age10, int age11, int age12, int age13, int age14, int age15, int age16, int age17, int age18, int age19)
        {
            Id = id;
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
}