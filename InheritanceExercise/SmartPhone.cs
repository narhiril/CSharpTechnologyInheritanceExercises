using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class SmartPhone : Computer
    {
        public int CurrentBatteryPercentage { get; protected set; } = 0;
        public bool IsWaterproof { get; set; } = false;
        public SmartPhone(string manufacturer, string model, string os) : base(manufacturer, model, os) { }
        public override void RechargeBattery()
        {
            CurrentBatteryPercentage = 100;
        }

        public string Call()
        {
            return "Ring ring, I'm a phone!";
        }
    }
}
