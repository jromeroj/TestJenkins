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
        [SetUp]
        public void Setup()
        {
            watherF = new API_Demo.WeatherForecast();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}
