using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Methoddemo
{
    class Vehicle
    {
        public int model_number;
        public string vehicle_type;
        public int wheels;
      

        public void Acceptdetails(int modeln, string vech_t, int whe)
        {
            model_number=modeln;
            vehicle_type = vech_t;
            wheels = whe;
        }

        public void avg()
        {
            if (wheels<=4)
            {
                Console.WriteLine("Average is 60.");
            }
            else
            {
                Console.WriteLine("Average is 15.");
            }
        }
        public void Display()
        {
            Console.WriteLine(model_number + " " + vehicle_type + " " + wheels);

        }


       static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Acceptdetails(245678, "scooty" ,2);
            v.Display();
            v.avg();
        }
        
        }

    }

