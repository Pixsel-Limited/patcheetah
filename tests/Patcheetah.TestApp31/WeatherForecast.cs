using Patcheetah.Attributes;
using System;

namespace Patcheetah.TestApp31
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [RequiredOnPatching]
        [JsonAlias("Summ")]
        public string Summary { get; set; }

        [IgnoreOnPatching]
        public EnTest EnTest { get; set; }
    }

    public enum EnTest
    {
        One, Two
    }
}
