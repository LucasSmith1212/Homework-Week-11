/// Week 11 Project 1
/// File Name: week11project1.cs
/// Author: Lucas Smith
/// Date:  November 8, 2021
///
/// Problem Statement: reate a class called Vehicle that has the Manufracturer name (enum), number of Cyclinders in the engine (int), and the owner (Person, see below).
/// Then create a classs called Truck that is derived from Vehicle and has the additional following properties: the load capacity in tons (double), and towing capacity in pounds (int).
/// 
/// 
/// Overall Plan:
/// 1) Declare public classes Person, Vehicle and child class Truck
/// 2) Declare the methods inside Person and Truck (since Truck extends Vehicle, it still uses Vehicle's variables)
/// 3) Test each method inside Main

using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Truck truck = new Truck();

            Console.WriteLine("What is the owner's name?");
            person.SetName(Console.ReadLine());
            string ownerName = person.getName();
            truck.setOwner(ownerName);

            Console.WriteLine("What is the manufacturer?");
            truck.setManufacturer(Console.ReadLine());

            Console.WriteLine("What is the number of cylinders in the engine?");
            truck.setCylinders(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("What is the loading capacity (in pounds)?");
            truck.setLoad(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("What is the towing capacity (in pounds)?");
            truck.setTowing(Convert.ToInt32(Console.ReadLine()));

            string manufacturer = truck.getManufacturer();
            int cylinderCount = truck.getCylinderCount();
            double loadingCapacity = truck.getLoad();
            int towingCapacity = truck.getTow();

            Console.WriteLine();
            Console.WriteLine("Truck Registration Information: ");
            Console.WriteLine("Manufaturer: " + manufacturer);
            Console.WriteLine("Owner: " + ownerName);
            Console.WriteLine("Cylinder Count: " + cylinderCount);
            Console.WriteLine("Loading Capacity: " + loadingCapacity);
            Console.WriteLine("Towing Capacity: " + towingCapacity);
            Console.WriteLine();

            person.SetName("John");
            ownerName = person.getName();
            Console.WriteLine(person.Equals(ownerName));
            Console.WriteLine();

            Console.WriteLine(truck.ToString());
        }
    }

    public class Person
    {
        private string name;

        public Person()
        {
            this.name = "Lucas";
        }

        public Person(string thisName)
        {
            name = thisName;
        }

        public Person (Person obj)
        {
            name = obj.name;
        }

        public string getName()
        {
            return name;
        }

        public void SetName(string name)
        {
            name = this.name;
        }

        public override string ToString()
        {
            return ("Owner's Name is: " + name);
        }

        public bool equals(Object obj)
        {
            return name.Equals(obj);
        }
    }

    public class Vehicle
    {
        protected string manufacturer;
        protected int numCylinders;
        protected string owner;

        public Vehicle()
        {
            this.manufacturer = "Honda";
            this.numCylinders = 6;
            this.owner = "Lucas";
        }

        public string getManufacturer()
        {
            return manufacturer;
        }

        public string getOwner()
        {
            return owner;
        }

        public int getCylinderCount()
        {
            return numCylinders;
        }

        public void setManufacturer(string creator)
        {
            manufacturer = creator;
        }

        public void setOwner(string owner)
        {
            owner = this.owner;
        }

        public void setCylinders(int cylinder)
        {
            numCylinders = cylinder;
        }

        public override string ToString()
        {
            return ("A vehicle made by " + manufacturer + ". Owned by " + owner + ". Number of Cylinders: " + numCylinders);
        }

        public bool equals(object obj)
        {
            return (manufacturer.Equals(obj) || numCylinders.Equals(obj) || owner.Equals(obj));
        }
    }

    public class Truck : Vehicle
    {
        private double loadCap;
        private int towingCap;

        public Truck()
        {
            this.manufacturer = "Honda";
            this.numCylinders = 6;
            this.owner = "Lucas";
            this.loadCap = 750.5;
            this.towingCap = 1000;
        }

        public Truck(string manufacturer, int numCylinders, string owner, double loadCap, int towingCap)
        {
            manufacturer = this.manufacturer;
            numCylinders = this.numCylinders;
            owner = this.owner;
            loadCap = this.loadCap;
            towingCap = this.towingCap;
        }

        public double getLoad()
        {
            return loadCap;
        }

        public int getTow()
        {
            return towingCap;
        }

        public void setLoad(double load)
        {
            loadCap = load;
        }

        public void setTowing(int tow)
        {
            towingCap = tow;
        }

        public override string ToString()
        {
            return ("Manufacturer: " + manufacturer + " Owner: " + owner + " # of Cylinders: " + numCylinders.ToString() + " Towing Capacity: " + towingCap + " Load Capactiy: " + loadCap);
        }

        public new bool equals(object obj)
        {
            return (manufacturer.Equals(obj) || numCylinders.Equals(obj) || owner.Equals(obj) || loadCap.Equals(obj) || towingCap.Equals(obj));
        }
    }
}