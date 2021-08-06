using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int berkay = 2;
            String x = "selam";
            byte b = 5; //1 byte
            sbyte c = 5; //2 byte

            short s = 5 ;     //2byte
            ushort us = 5;   //2byte

            Int16 i16 = 5;   //2 byte
            int i = 5;      //4byte
            Int32 i32 = 5;  //4byte
            Int64 i64 = 5;  //8byte
            uint ui = 5;    //4byte
            long l= 4;      //8byte
            ulong ul = 5;   //8byte

            float f =5;        //4byte
            double d = 5;     //8byte
            decimal de =5;     //16byte

            char ch = 'a' ;          //2byte
            string str = "berkay";   //sınırsız 

            bool bl = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 4.3;


            string str20 = "20";
            int int20 = 20;

            string aa = str20 + int20.ToString();

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            string datetime = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(datetime);

            




            Console.WriteLine("Hello World!");
            Console.WriteLine(berkay);
            Console.WriteLine(x);
        }
    }
}
