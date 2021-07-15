using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame
{
    public class Game
    {
        public class JsonData
        {
            public Jeopardy[] jeopardy { get; set; }
            [JsonProperty("double jeopardy")]
            public DoubleJeopardy[] doublejeopardy { get; set; }
            [JsonProperty("final jeopardy")]
            public FinalJeopardy finaljeopardy { get; set; }
            public string message { get; set; }
        }

        public class FinalJeopardy
        {
            public string id { get; set; }
            public string category { get; set; }
            public string clue { get; set; }
            public string answer { get; set; }
        }

        public class Jeopardy
        {
            public string id { get; set; }
            public string category { get; set; }
            public object value { get; set; }
            public string clue { get; set; }
            public string answer { get; set; }
            public int order { get; set; }
        }

        public class DoubleJeopardy
        {
            public string id { get; set; }
            public string category { get; set; }
            public object value { get; set; }
            public string clue { get; set; }
            public string answer { get; set; }
            public int order { get; set; }
        }

    }
}
