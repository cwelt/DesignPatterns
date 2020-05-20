using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        // instance data 
        private float _currentPressure;
        private float _lastPressure;
        private ISubject _weatherData;

        // constructor 
        public ForecastDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        // implement display-element interface 
        public void Display()
        {
            Console.Write("Forecast:");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        // implement observer interface 
        public void Update(float temperature, float humidity, float pressure)
        {
            this._lastPressure = _currentPressure;
            this._currentPressure = pressure;
            Display();
        }
    }
}
