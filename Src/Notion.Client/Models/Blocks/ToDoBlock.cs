﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ToDoBlock : Block
    {
        public override BlockType Type => BlockType.ToDo;

        [JsonProperty("to_do")]
        public Info ToDo { get; set; }

        public class Info
        {
            [JsonProperty("text")]
            public IEnumerable<RichTextBase> Text { get; set; }

            [JsonProperty("checked")]
            public bool IsChecked { get; set; }

            [JsonProperty("children")]
            public IEnumerable<Block> Children { get; set; }
        }
    }
}
