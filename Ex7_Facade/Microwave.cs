using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7_Facade
{
    class Microwave
    {
        private Drive _drive;
        private Power _power;
        private Notification _notification;
        public Microwave(Drive drive, Power power, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
        }

        public void Defrost()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 1000;
            _drive.TurnRight();
            _drive.TurnRight();
            _power.MicrowavePower = 500;
            _drive.Stop();
            _drive.TurnLeft();
            _drive.TurnLeft();
            _power.MicrowavePower = 200;
            _drive.Stop();
            _drive.TurnRight();
            _drive.TurnRight();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }

        public void Cook()
        {
            _notification.StartNotification();

            _power.MicrowavePower = 3000;
            _drive.TurnRight();
            _drive.TurnRight();
            _drive.TurnRight();
            _drive.TurnRight();
            _drive.Stop();
            _power.MicrowavePower = 1500;
            _drive.TurnLeft(); 
            _drive.TurnLeft();
            _drive.TurnLeft();
            _drive.TurnLeft();
            _drive.Stop();
            _power.MicrowavePower = 0;

            _notification.StopNotification();
        }
    }
}
