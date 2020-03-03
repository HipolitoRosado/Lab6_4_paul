using System;
using System.Collections.Generic;
using System.Text;



namespace Lesson6_2_Paul

{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal(4, 0, "Cat", "Snowball", true);
            Animal animal2 = new Animal(8, 0, "Spider", "Friendly", false);
            Animal animal3 = new Animal(2, 2, "Monkey", "Bobo", false);


            animal1.ShowDetails();
            animal2.ShowDetails();
            animal3.ShowDetails();


            animal1.SendToObedienceSchool();
            animal2.SendToObedienceSchool();
            animal3.SendToObedienceSchool();

            animal1.Evolve(2,12);
            animal1.ShowDetails();
        }

    }
}
    

