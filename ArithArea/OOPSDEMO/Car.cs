using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.OOPSDEMO
{
    class Car
    {
        public int model_number;
        public string car_name;
        public int car_price;
        public string car_color;

        static void Main(string[]args)
        {
            Car audi = new Car();
            audi.car_name = "audi";
            audi.model_number = 2345;
            audi.car_price = 9000000;
            audi.car_color = "black";
            Console.WriteLine(audi.car_name + " " + audi.model_number + " " + audi.car_price + " " + audi.car_color);

            Car hondacity = new Car();
            hondacity.car_name = "hondacity";
            hondacity.model_number = 678906;
            hondacity.car_price = 121000000;
            hondacity.car_color = "white";

            Console.WriteLine(hondacity.car_name + " " + hondacity.model_number + " " + hondacity.car_price + " " + hondacity.car_color);

            Car swift = new Car();
            swift.car_name = "swift";
            swift.model_number = 247869;
            swift.car_price = 150000;
            swift.car_color = "black";

            Console.WriteLine(swift.car_name + " " + swift.model_number + " " + swift.car_price + " " + swift.car_color);



        }

    }
}
