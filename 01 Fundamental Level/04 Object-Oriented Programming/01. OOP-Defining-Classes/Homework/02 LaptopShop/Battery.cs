using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    public class Battery
    {
        private string batteryType;
        private double? batteryLife; // in hours

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if (value != null && value == string.Empty)
                {
                    throw new ArgumentException("Invalid battery model.");
                }
                this.batteryType = value;
            }
        }

        public double? BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException("Invalid battery capacity.");
                }
                this.batteryLife = value;
            }
        }

        public Battery (string batteryType = null, double? batteryLife = null)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }

        public override string ToString()
        {
            return string.Format("Battery type: {0}, Battery life: {1} hours", this.BatteryType, this.BatteryLife);
        }
    }
}
