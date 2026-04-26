using Smart_Home__Ağıllı_Ev__Sistemi.Interface;
using Smart_Home__Ağıllı_Ev__Sistemi.Models.Comman;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home__Ağıllı_Ev__Sistemi.Models
{
    public class SmartLight : SmartDevice, IDevice
    {
        public int Brightness { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Smratligt turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Smratligt turn off");
        }

        public override void PerformAction()
        {
            Console.WriteLine($"Brightness; {Brightness}");
        }
        public override void ShowStatus()
        {
            base.ShowStatus();
        }
    }
}
