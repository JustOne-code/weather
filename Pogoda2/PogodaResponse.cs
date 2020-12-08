using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogoda2
{
    class PogodaResponse
    {
        public string Name { set; get; }

        public string Country { set; get; }

        public SysInfo Sys { set; get; }

        public MainInfo Main { set; get; }

        public WindInfo Wind { set; get; }

        public int Visibility { set; get; }

        public WeatherInfo[] Weather { set; get; }
    }
    class MainInfo
    {
        public float Temp { set; get; }
        public float Pressure { set; get; }
        public float Humidity { set; get; }
    }

    class SysInfo
    {
        public string Country { set; get; }

        public int Sunrise { set; get; }
        public int Sunset { set; get; }
    }

    class WindInfo
    {
        public float Speed { set; get; }
        public int Deg { set; get; }
    }

    class WeatherInfo
    {
        public string Description { set; get; }
        public string Icon { set; get; }
    }
}
