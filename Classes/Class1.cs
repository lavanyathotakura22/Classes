using System;
namespace Classes
{
    class Class1
    {
        string color = "red";
        int maxSpeed = 200;
        string model;

        static void Main(string[] args)
        {
            Class1 myObj = new Class1();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.color = "Blue";
            myObj.maxSpeed = 500;
            myObj.model = "Mustang";
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            Console.WriteLine(myObj.model);
        }
    }
}