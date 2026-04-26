using Smart_Home__Ağıllı_Ev__Sistemi.Interface;
using Smart_Home__Ağıllı_Ev__Sistemi.Models.Comman;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home__Ağıllı_Ev__Sistemi.Models
{
    public class SmartDoor : SmartDevice, IDevice
    {
        public string IsLocked { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("SmartDoor turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("SmartDoor turn off");
        }

        public override void PerformAction()
        {
            Console.WriteLine($"SmartDoor; {IsLocked}");
        }
        public override void ShowStatus()
        {
            base.ShowStatus();
        }
    }
}
