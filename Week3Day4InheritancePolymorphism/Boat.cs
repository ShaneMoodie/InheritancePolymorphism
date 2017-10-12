using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day4InheritancePolymorphism
{
    class Boat : Vehicle 
    {
        private double waterDrag;

        public Boat(int seats, int carryCap, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryCap = carryCap;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }


        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;
        }
    }
}
