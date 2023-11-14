using System.Xml.Linq;

namespace OpenWeatherMapCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            string api = "edf64c91c69cdaa7166158b5da5ff830";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument weather = XDocument.Load(connection);
            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var wind = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var humidity = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var weathr = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;

            label4.Text = temp.ToString();
            label13.Text = temp.ToString();
            label7.Text = wind + " m/s";
            label8.Text = humidity + " %";
            label10.Text = weathr;

            if (weathr == "açýk")
            {
                pictureBox1.ImageLocation = @"C:\Users\Rabia\source\repos\OpenWeatherMapCard\OpenWeatherMapCard\images\sunny.png";
            }
            else if (weathr == "bulutlu")
            {
                pictureBox1.ImageLocation = @"C:\Users\Rabia\source\repos\OpenWeatherMapCard\OpenWeatherMapCard\images\cloudy.jpeg";

            }
            else if (weathr == "karlý")
            {
                pictureBox1.ImageLocation = @"C:\Users\Rabia\source\repos\OpenWeatherMapCard\OpenWeatherMapCard\images\snowy.png";

            }
            else if (weathr == "rüzgarlý")
            {
                pictureBox1.ImageLocation = @"C:\Users\Rabia\source\repos\OpenWeatherMapCard\OpenWeatherMapCard\images\windy.png";

            }
            else if (weathr == "yaðmurlu")
            {
                pictureBox1.ImageLocation = @"C:\Users\Rabia\source\repos\OpenWeatherMapCard\OpenWeatherMapCard\images\rainy.png";

            }
        }


    }
}