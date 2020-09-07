using System;
using System.CodeDom;
using System.Collections.Generic;
namespace CompleteCSharpMasterclass

{
    class MainClass
    {
        private static void Main(string[] args)
        {
            //a car can be a BMW, Porsche etc.
            //Polymorphism at work #1: an Audi, a BMW, a Porsche..
            //can all be used wherever a "Car" class is expected. No cast is required because an implicit conversion exists from a derived class to its base class.

            //you can use subclass when using a list of base class..
            var listCars = new List<Car>
            {
                new Bmw(150, "black", "M3"),
                new Audi(165, "silver", "A5")
            };

            //Polymorphism at work #2: the VIRTUAL method Repair() is invoked on each of the derived classes, not the base class... V I R T U A L
            foreach (var car in listCars)
            {
                car.Repair();
            }

            /*//uses ShowDetail() of base class.
            Car beemer1 = new Bmw(300, "red", "m5");
            beemer1.ShowDetails();
            
            //uses ShowDetail() of derived class. Could be also:  Bmw beemer2 = new Bmw!
            var beemer2 = new Bmw(250, "green", "m1");
            beemer2.ShowDetails();

            //still is a derived class - uses the classes ShowDetail() method...
            var beemer3 =  beemer2;
            beemer3.ShowDetails();
            
            //explicitly casted Base class (Car) to beemer4.
            var beemer4 = (Car) beemer2;
            beemer4.ShowDetails();

            var beemerM3 = new M3(366, "blue", "m3");
            beemerM3.ShowDetails();*/

            Car bmwZ3 = new Bmw(200, "black", "Z3");
            Car audiA3 = new Audi(100,"green","A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            Bmw bmwM5 = new Bmw(330,"white","M5");
            bmwM5.ShowDetails();

            Car carB = (Car) bmwM5;
            carB.ShowDetails();

        }
    }
}



    

