﻿using Newtonsoft.Json;

namespace Notion.Client
{
    public class NumberPropertyItem : SimplePropertyItem
    {
        public override string Type => "number";

        [JsonProperty("number")]
        public Number Number { get; set; }
    }
}
