using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day4InheritancePolymorphism
{
    class Automobile : Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryCap, string color, double movementSpeed)
        {
            //these fields are in the Automobile class
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            // these fields are in the Vehicle Class
            this.seats = seats;
            this.carryCap = carryCap;
            this.color = color;
            this.movementSpeed = movementSpeed;

        }
    }
}
