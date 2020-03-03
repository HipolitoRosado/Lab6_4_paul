using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6_2_Paul
{
    class Animal

    {
        private int legs { get; set; }
        private int arms { get; set; }
        private string type { get; set; }
        private string name { get; set; }
        private bool isDangerous { get; set; }

        public Animal(int legs, int arms, string type, string name, bool isDanerous)
        {
            this.legs = legs;
            this.arms = arms;
            this.name = name;
            this.isDangerous = isDangerous;

        }
        public void ShowDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Type of animal: " + type);
            Console.WriteLine("Number of arms: " + arms);
            Console.WriteLine("Number of legs: " + legs);
            Console.WriteLine("Dangerous?: " + isDangerous);

            }
        
        public void SendToObedienceSchool()
        {
            if (isDangerous)
            {
                isDangerous = false;
                Console.WriteLine(name + " is a good animal" + type + "now");
            }
            else
            {
                Console.WriteLine(name + " is'nt dangerous");
            }
        }

        public void Evolve(int newArms, int newLegs)
        {
            arms = newArms;
            legs = newLegs;
            type = "Something Else!";
        }


    }
}
