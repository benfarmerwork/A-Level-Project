using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.ClientUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherserviceclient = new WeatherService.WeatherServiceClient();
            DateTime? LastLog = weatherserviceclient.GetMostRecentWeatherLogDateTime(3);

            Console.WriteLine("Last Log : " + LastLog.Value.ToString());
            Console.ReadLine();
        }
    }
}
