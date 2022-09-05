using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        public string Location { get; private set; }
        public double TemperatureInCelcius { get; private set; }
        
        private enum Temperature
        {
            Cold = 10,
            Hot = 30
        }

        public WeatherReporter(string location, double temperatureInCelcius)
        {
            Location = location;
            TemperatureInCelcius = temperatureInCelcius;
        }

        public string PrintWeatherInfo()
        {
            return $"I am in {Location} and it is {CheckWheather()}.";
        }

        public string CelciusToFarenheit()
        {
            //convert celcius to ferenheit
            double tempInFarenheit = (9.0 / 5.0) * TemperatureInCelcius + 32;
            return $"The temperature in Fahrenheit is {tempInFarenheit}.";

        }

        public string CheckWheather()
        {
            string temperatureInfo;
            switch (TemperatureInCelcius)
            {
                case >= (int)Temperature.Hot:
                    temperatureInfo = "It's too hot 🥵!";
                    break;
                case <= (int) Temperature.Cold:
                    temperatureInfo = "It's too cold 🥶!";
                    break;
                default:
                    temperatureInfo = "Ahhh...it's just right 😊!";
                    break;
            }
            return temperatureInfo;

        }

        /* public string Check1()
         {
             if (Location == "London")
             {

                 return "🌦";

             }
             else if (Location == "California")
             {

                 return "🌅";

             }
             else if (Location == "Cape Town")
             {

                 return "🌤";

             }
             return "🔆";
         }*/



    }
}

