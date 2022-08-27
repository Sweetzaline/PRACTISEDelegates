//Call the three methods using delegates.

using System;
namespace GenricDelegates
{
    //public delegate double Del1(int x, float y, double z);
    //public delegate void Del2(int x, float y, double z);
    //public delegate bool Del3(string str);
    class Program
    {
        public static double AddNums1(int x, float y, double z)//value(double) returning method
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)//non value returning method
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CeckLength(string str)//value(boolean) returning method
        {
            if (str.Length > 5)
                return true;
            else
                return false;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Generic Delegates!\n");

            Func<int, float, double, double>  obj1 = AddNums1; //other methods are also there to instanciate the delegate
            double result = obj1.Invoke(1, 3.6f, 5.7);
            Console.WriteLine(result);
            
            Action<int, float, double> obj2 = AddNums2; 
            obj2.Invoke(1, 3.6f, 5.7);
            
            Predicate<string> obj3 = CeckLength; //or use func delegate: Func<string, bool>
            bool ans=obj3.Invoke("sweety");
            Console.WriteLine(ans);

        }
    }
}
