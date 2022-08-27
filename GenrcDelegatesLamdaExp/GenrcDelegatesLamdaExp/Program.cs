//Call the three methods using delegates.

using System;
namespace GenricDelegates
{
    //public delegate double Del1(int x, float y, double z);
    //public delegate void Del2(int x, float y, double z);
    //public delegate bool Del3(string str);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Delegates!\n");

            Func<int, float, double, double> obj1 = (x,y,z) => x + y + z; //lamda operator
            double result = obj1.Invoke(1, 3.6f, 5.7);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) => Console.WriteLine(x + y + z); //for single line of return codes, write  like this
            obj2.Invoke(1, 3.6f, 5.7);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                else
                    return false;

            }; 
            bool ans = obj3.Invoke("sweety");
            Console.WriteLine(ans);

        }
    }
}
