using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day4InheritancePolymorphism
{
    class Vehicle
    {

        protected int seats;
        protected int carryCap;
        protected string color;
        protected double movementSpeed;
        private float gearRatio;
        private float engineSize;
        protected double distanceTraveled;

        public int Seats
        {
            get { return this.seats; }
        }


        public int CarryCap
        {
            get { return this.carryCap; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        public Vehicle()
        {
        }

        public Vehicle(int seats, int carryCap, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryCap = carryCap;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0.0d;

        }

        public virtual void Move()
        {
            //distanceTraveled = distanceTraveled + movementSpeed;
            distanceTraveled += movementSpeed;
        }


    }
}
