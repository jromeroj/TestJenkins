using API_Demo.Controllers;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitarias
{
    public  class WatherForecastTest
    {
        API_Demo.WeatherForecast watherF;
        API_Demo.Controllers.WeatherForecastController api;
        [SetUp]
        public void Setup()
        {
            watherF = new API_Demo.WeatherForecast();
            
        }
        private readonly ILogger<WeatherForecastController> _logger;
        [Test]
        public void TestGetMethod()
        {
            
        api = new API_Demo.Controllers.WeatherForecastController(_logger);
            var tempMayor = api.Get().Where(x => x.TemperatureC >= 0).Count();
            Assert.IsTrue(tempMayor >= 1);
            Assert.IsFalse(tempMayor <= 0);


        }

    }
}
