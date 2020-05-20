using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        // private insatnce data fields 
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        // public properties 
        private List<IObserver> Observers { get => _observers; set => _observers = value; }

        // Constructor 
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }


        // Observer interface implementation: 
        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
            Console.WriteLine();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // notify observers when weather measurements change 
        public void measurementsChanged()
        {
            NotifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            measurementsChanged();
        }
    }
}
