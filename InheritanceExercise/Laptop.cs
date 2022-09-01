using System;

namespace InheritanceExercise
{
    public class Laptop : Computer
    {
        public int CurrentBatteryPercentage { get; protected set; } = 0;
        public Laptop(string manufacturer, string model, string os) : base(manufacturer, model, os) { }
        public override void RechargeBattery()
        {
            CurrentBatteryPercentage = 100;
        }
    }
}
