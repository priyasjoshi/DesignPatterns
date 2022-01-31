using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatterns.Observer
{
    class WeatherData : Subject
    {
        private ArrayList observers;
        private float temprature;
        private float humidity;
        private float pressure;
        public WeatherData() {
            this.observers = new ArrayList();
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.update(temprature, humidity, pressure);
            }
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >=0)
            {
                observers.Remove(i);
            }
        }
        public void MeasurementChanged() {
            notifyObservers();
        }
        public void setMeasurements(float temprature,float humidity,float pressure) {
            this.temprature = temprature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
