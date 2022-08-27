using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousMethod
{

  ///  public delegate string GreetDel(string name); //defining delegate
    class JustDelegate
    {
        public static string Greetings(string name)
        {
            return "hello" + name + " a very goodmorning";
        }
    /// static void Main()
     /// {
     ///    GreetDel obj = new GreetDel(Greetings); // instanciating the delegate(creating instance ofthe delegate)
     ///    string str = obj.Invoke("Sweety");// invoke the delegate
     ///    Console.WriteLine(str);
     ///  }
    }

}





