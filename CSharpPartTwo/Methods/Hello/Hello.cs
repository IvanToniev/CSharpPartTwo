using System;

namespace Hello
{
    class Hello
    {
        static void hello(string name)
        { 
            Console.WriteLine("hello,{0}",name);
        }

        static void Main()
        {
            hello("ivan");
        }
    }
}
