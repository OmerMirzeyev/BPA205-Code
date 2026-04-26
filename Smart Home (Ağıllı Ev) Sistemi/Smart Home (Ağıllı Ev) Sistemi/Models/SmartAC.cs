using Smart_Home__Ağıllı_Ev__Sistemi.Interface;
using Smart_Home__Ağıllı_Ev__Sistemi.Models.Comman;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home__Ağıllı_Ev__Sistemi.Models
{
    public class SmartAC : SmartDevice , IDevice
    {

        public int Temperature { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("SmartAC turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("SmartAC turn off");
        }

        public override void PerformAction()
        {
            Console.WriteLine($"Temperature; {Temperature}");
        }
        public override void ShowStatus()
        {
            base.ShowStatus();
        }
    }
}
