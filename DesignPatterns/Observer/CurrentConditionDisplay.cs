using System;

namespace DesignPatterns.Observer
{
    class CurrentConditionDisplay : Observer, IDisplayElement
    {
        private float temprature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Current Conditions:" + temprature + "F degrees and " + "humidity :" + humidity);
        }
        public void update(float temp, float humidity, float pressure)
        {
            this.temprature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
