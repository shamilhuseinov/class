using System;
namespace test
{
    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public byte age;

        public void ReturnDetails()
        {
            Console.WriteLine($" name: {name} \n breed: {breed} \n age: {age}");
        }
    }
}

