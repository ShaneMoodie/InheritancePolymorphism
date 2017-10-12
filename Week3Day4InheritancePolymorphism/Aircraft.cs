using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day4InheritancePolymorphism
{
    class Aircraft : Vehicle
    {
        private double altitude;
        public Aircraft(int seats, int carryCap, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryCap = carryCap;
            this.color = color;
            this.movementSpeed = movementSpeed;

            this.altitude = 0.0d;
        }

        public override void Move()
        {
            altitude += 10000.0d; 
            base.Move();
        }
    }
}
