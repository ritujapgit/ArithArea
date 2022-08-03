using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.OOPSDEMO
{
    class Animal
    {
        public string animal_name;
        public int legs;
        public string food_type;
        static void Main(string[]args)
        {
            Animal Cat = new Animal();
            Cat.animal_name = "Cat";
            Cat.legs = 4;
            Cat.food_type = "OMNIVIROUS";

            Console.WriteLine(Cat.animal_name + " " + Cat.legs + " " + Cat.food_type);

            Animal elephant = new Animal();
            elephant.animal_name = "Elephant";
            elephant.legs = 4;
            elephant.food_type = "HERBIVOROUS";

            Console.WriteLine(elephant.animal_name + " " + elephant.legs + " " +elephant.food_type);









        }
    }
}
