//1
using System;
namespace test
{
    public class Program
    {
        static void Main()
        {
            var dog = new Animal();
            dog.name = "Pablo";
            dog.breed = "male";
            dog.color = "black";
            dog.age = 4;
            dog.ReturnDetails();

            var cat = new Animal();
            cat.name = "Kate";
            cat.breed = "female";
            cat.color = "orange";
            cat.age = 2;
            cat.ReturnDetails();

        }
    }
}

//2
//using System;
//namespace test
//{
//    public class program
//    {
//        static void Main()
//        {
//            var building1 = new Building();
//            building1.name = "FlameTower";
//            building1.height = 100;
//            building1.area = 340;
//            Console.WriteLine($"volume1: {building1.FindVolume()}");

//            var building2 = new Building();
//            building2.name = "BakuTower";
//            building2.height = 50;
//            building2.area = 280;
//            Console.WriteLine($"volume2: {building2.FindVolume()}"); 

//        }
//    }

//}
