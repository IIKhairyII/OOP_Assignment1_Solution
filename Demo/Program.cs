using Common.DemoClasses;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA a = new();
            //TypeB b = new(); //Invalid as the class is internal
            a._c = 20; //Valid as _c is public
            //a._a = 50; // invalid as _a is private
            //a._b = 60; // invalid as _b is protected and valid only for sub classes of TypeA
            //a._d = 70; // Invalid as _d is internal
            Structs myStruct = new();
            myStruct.Id = 1;
            myStruct.SetName("Khairy");
            Console.WriteLine($"This is {myStruct.GetName()} with id = {myStruct.Id}");
            //Console.WriteLine(myStruct.Name); //invalid as Name is internal 
        }
    }
}