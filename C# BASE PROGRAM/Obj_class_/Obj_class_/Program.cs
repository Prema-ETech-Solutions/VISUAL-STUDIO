using System;

namespace Obj_class_
{
    class Program
    {
        string code = "LS";
        static string LS = "code";
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.code);
            Console.WriteLine(LS);
            P1 objs = new P1();
            Console.WriteLine(objs.code);
            Console.WriteLine(P1.LS);
            
        }
    }
    class P1
    {
        public string code = "LS";
       public static string LS = "code";
    }
}
