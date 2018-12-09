using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.ViewModel
{
    public class ResponseCategoryViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("att_name1")]
        public string AttName1 { get; set; }

        [JsonProperty("att_name2")]
        public string AttName2 { get; set; }

        [JsonProperty("att_name3")]
        public string AttName3 { get; set; }

        [JsonProperty("att_name4")]
        public string AttName4 { get; set; }

        [JsonProperty("att_name5")]
        public string AttName5 { get; set; }

        [JsonProperty("att_name6")]
        public string AttName6 { get; set; }

        [JsonProperty("att_name7")]
        public string AttName7 { get; set; }

        [JsonProperty("att_name8")]
        public string AttName8 { get; set; }

        [JsonProperty("att_name9")]
        public string AttName9 { get; set; }

        [JsonProperty("att_name10")]
        public string AttName10 { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

    }
}