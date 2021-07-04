using System;

namespace EcmaAPI
{
    public class EntityModel
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Stream
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
    }

    public class Popular
    {
        public string Title { get; set; }
        public int TimeM { get; set; }
        public int Lession { get; set; }
        public string Description { get; set;}
        public string Avatar { get; set; }
        public string Bg { get; set; }
    }
}
