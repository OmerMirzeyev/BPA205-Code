using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home__Ağıllı_Ev__Sistemi.Models.Comman
{
    public abstract class SmartDevice
    {
        public string DeviceName { get; set; }

        public abstract void PerformAction();
        public virtual void ShowStatus()
        {
            Console.WriteLine($"{DeviceName} is currently operational.");
        }
    }
}
