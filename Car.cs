using System;

// This name space represents the file folder that the class is in.
namespace classwork
{
    // The following Car is a class
    public class Car
    {
        // The following strings are fields
        string _tires;
        string _windows;
        string _doors;
        // string _gasoline;
        // string _model;

        // Standard long way of Property
        public string TypeTire {
            get {
                return _tires;
            }
            set {
                this._tires = value;
            }
        }

        public string Window {
            get {
                return _windows;
            }
            set{
                this._windows = value;
            }
        
        }

        public string Door {
            get {
                return _doors;
            }
            set {
                this._doors = value;
            }
        }

        // Shorthand way of a Property + field
        public string Gas { get; set; }

        public string YearMake { get; set; }

        // The following are methods
        public void EngageTire()
        {
            Console.WriteLine("Spiked");
        }

        public void ShadeWindow()
        {
            Console.WriteLine("Tinted");
        }

        public void ClosedDoor()
        {
            Console.WriteLine("Four Doors");
        }
        
        public void Octane()
        {
            Console.WriteLine("On Empty");
        }

        public void TypeOfCar()
        {
            Console.WriteLine("Kia 2009");
            Console.WriteLine("another test");
        }
    }
}