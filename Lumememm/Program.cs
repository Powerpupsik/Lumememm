using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumememm
{
    class Program
    {

        class Snowman
        {
            
            string name;
            double mass=10;

            public Snowman(string _name)
            {
                name = _name;
                
                
            }
                 
            public string Name
            {
                get { return name; }
                
               
            }

            public double Mass
            {
                get { return mass; }
                                                 
            }
            public void Melt(int temperature)
            {
                if (temperature >= 0)
                {
                    mass -= mass * 0.2; //või mass = mass - (mass * 0.2);
                    Console.WriteLine("Help! I'm melting!");
;               }
            }
        }

        
        static void Main(string[] args)
        {
            //Lumememmme loomine
            Snowman snowman = new Snowman("Olaf");

            Console.WriteLine($"Hello, I'm {snowman.Name}");
            Random rnd = new Random();

            //3 päeva õues seismist

            for (int i =0; i<3; i++)
            {
                int temperature = rnd.Next(-5, 11);
                Console.WriteLine($"It is {temperature} degree today");
                snowman.Melt(temperature);
            }

            Console.WriteLine($"Mass of the snowman after three days: {snowman.Mass}");


            Console.ReadLine();
        }
    }
}
