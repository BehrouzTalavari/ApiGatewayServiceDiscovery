using System;

namespace CachedDataApi
{
    public class PersonData
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public string PersonName { get; internal set; }
        public DateTime DateRead { get; internal set; }
        public int Id { get; internal set; }
    }
}
