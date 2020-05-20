using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        // instance data 
        private float _maxTemperature = 0F;
        private float _minTemperature = 100F;
        private float _temperatureSum = 0;
        private float _temperature;
        private uint _numberOfReadings = 0;
        private ISubject _weatherData = null;

        // constructor 
        public StatisticsDisplay(ISubject weatherData)
        {
            // register observer and store it's reference 
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        // implement display-element interface 
        public void Display()
        {
            Console.WriteLine($"Statistics: Average: {_temperatureSum/_numberOfReadings:N2},"
                            + $" Max: {_maxTemperature:N2}, Min: {_minTemperature:N2}"); 
        }

        // implement observer interface 
        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            _numberOfReadings++;
            _temperatureSum += temperature;
            if (temperature > _maxTemperature)
                _maxTemperature = temperature;
            if (temperature < _minTemperature)
                _minTemperature = temperature;
            Display();
        }
    }
}
