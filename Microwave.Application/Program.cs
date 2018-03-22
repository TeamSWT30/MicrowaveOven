using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicrowaveOvenClasses.Boundary;
using MicrowaveOvenClasses.Controllers;

namespace Microwave.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup all the objects, 
            var door = new Door();
            var output = new Output();
            var light = new Light(output);
            var timer = new Timer();
            var display = new Display(output);
            var powertube = new PowerTube(output);
            var cooker = new CookController(timer, display, powertube);
            var powerButton = new Button();
            var startCancelButton = new Button();
            var timeButton = new Button();
            var UI = new UserInterface(powerButton, timeButton, startCancelButton, door, display, light, cooker);

            // Simulate user activities
            Console.WriteLine("Open door");
            door.Open();
            Console.WriteLine("Place dish in oven, close door");
            door.Close();
            Console.WriteLine("Press powerButton two times");
            powerButton.Press();
            powerButton.Press();
            Console.WriteLine("Press timeButton one time");
            timeButton.Press();
            Console.WriteLine("Press startCancelButton, wait until time runs out and get food");
            startCancelButton.Press();




            // Wait while the classes, including the timer, do their job
            System.Console.WriteLine("Tast enter når applikationen skal afsluttes");
            System.Console.ReadLine();
        }
    }
}
