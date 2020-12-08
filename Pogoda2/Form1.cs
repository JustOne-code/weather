using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogoda2
{
    public partial class Form1 : Form
    {
        private string city;
        public Form1(string str)
        {
            InitializeComponent();
            this.city = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&lang=ru&appid=d4dddcea88fe7a48db7028b32d9c4680&units=metric";
            HttpWebRequest req = (HttpWebRequest)System.Net.WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            PogodaResponse pr = JsonConvert.DeserializeObject<PogodaResponse>(response);
            LDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy, HH:mm");
            LCityAndCountry.Text = pr.Name + ", " + pr.Sys.Country;
            Ltemp.Text = pr.Main.Temp.ToString() + "° C";
            LDescription.Text = pr.Weather[0].Description;

            string picture = pr.Weather[0].Icon;

            if (picture == "01d")
            {
                pictureBox1.Image = Properties.Resources._01d;
            }
            else if (picture == "01n")
            {
                pictureBox1.Image = Properties.Resources._01n;
            }
            else if (picture == "02d")
            {
                pictureBox1.Image = Properties.Resources._02d;
            }
            else if (picture == "02n")
            {
                pictureBox1.Image = Properties.Resources._02n;
            }
            else if (picture == "03d")
            {
                pictureBox1.Image = Properties.Resources._03d;
            }
            else if (picture == "03n")
            {
                pictureBox1.Image = Properties.Resources._03n;
            }
            else if (picture == "04d")
            {
                pictureBox1.Image = Properties.Resources._04d;
            }
            else if (picture == "04n")
            {
                pictureBox1.Image = Properties.Resources._04n;
            }
            else if (picture == "09d")
            {
                pictureBox1.Image = Properties.Resources._09d;
            }
            else if (picture == "09n")
            {
                pictureBox1.Image = Properties.Resources._09n;
            }
            else if (picture == "10d")
            {
                pictureBox1.Image = Properties.Resources._10d;
            }
            else if (picture == "10n")
            {
                pictureBox1.Image = Properties.Resources._10n;
            }
            else if (picture == "11d")
            {
                pictureBox1.Image = Properties.Resources._11d;
            }
            else if (picture == "11n")
            {
                pictureBox1.Image = Properties.Resources._11n;
            }
            else if (picture == "13d")
            {
                pictureBox1.Image = Properties.Resources._13d;
            }
            else if (picture == "13n")
            {
                pictureBox1.Image = Properties.Resources._13n;
            }
            else if (picture == "50d")
            {
                pictureBox1.Image = Properties.Resources._50d;
            }
            else if (picture == "50n")
            {
                pictureBox1.Image = Properties.Resources._50n;
            }

            LPressureAndHumidity.Text = "Давление " + pr.Main.Pressure + " мм рт. ст. " + "Влажность " + pr.Main.Humidity + "%";

            string description = "Ветер " + pr.Wind.Speed.ToString() + " м/c " + "(";

            int degres = pr.Wind.Deg;

            if((degres > 0 && degres <= 11) || (degres >= 349 && degres <= 360))
            {
                description += "Северный";
            }
            else if (degres >= 12 && degres <= 33)
            {
                description += "Северный, Северо-Восточный";
            }
            else if (degres >= 34 && degres <= 56)
            {
                description += "Северо-Восточный";
            }
            else if (degres >= 57 && degres <= 78)
            {
                description += "Восточный, Северо-Восточный";
            }
            else if (degres >= 79 && degres <= 101)
            {
                description += "Восточный";
            }
            else if (degres >= 102 && degres <= 123)
            {
                description += "Восточный, Юго-Восточный";
            }
            else if (degres >= 124 && degres <= 146)
            {
                description += "Юго-Восточный";
            }
            else if (degres >= 147 && degres <= 168)
            {
                description += "Южный, Юго-Восточный";
            }
            else if (degres >= 169 && degres <= 191)
            {
                description += "Южный";
            }
            else if (degres >= 192 && degres <= 214)
            {
                description += "Южный, Юго-Западный";
            }
            else if (degres >= 215 && degres <= 236)
            {
                description += "Юго-Западный";
            }
            else if (degres >= 237 && degres <= 258)
            {
                description += "Западный, Юго-Западный";
            }
            else if (degres >= 259 && degres <= 281)
            {
                description += "Западный";
            }
            else if (degres >= 282 && degres <= 303)
            {
                description += "Западный, Северо-Западный";
            }
            else if (degres >= 304 && degres <= 326)
            {
                description += "Северо-Западный";
            }
            else if (degres >= 327 && degres <= 348)
            {
                description += "Северный, Серверо-Западный";
            }

            description += ") Видимость " + pr.Visibility.ToString() + " м";

            LSpeedVis.Text = description;

            DateTime sunrise = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            sunrise = sunrise.AddSeconds(pr.Sys.Sunrise);
            sunrise = sunrise.ToLocalTime();
            LSunrise.Text = "Восход " + sunrise.ToString("HH:mm");

            DateTime sunset = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            sunset = sunset.AddSeconds(pr.Sys.Sunset);
            sunset = sunset.ToLocalTime();
            LSunset.Text = "Закат " + sunset.ToString("HH:mm");

        }
    }
}
