///Instead of using Delegate to call a method, we can use Annonymous Method. 
///But suitable in lesser codes only.
///Without creating a new method, we can use an unnamed method, we can bind it with the delegate.
///No need to specify: method name, modifiers, 
///Lesser typing work
///Only need Delegate Keyword, parameters.
///
using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousMethod
{
    public delegate string GreetDel(string name); //defining delegate
    class AnonymousMethod
    {
       static void Main()
        {
            GreetDel obj = delegate (string name)
            {
                return "hello" + name + " a very goodmorning";//Logic is here, at the place where the binding is performed.
            };
            
            string str = obj.Invoke("Sweety");// invoke the delegate
            Console.WriteLine(str);
        }
    }
}
