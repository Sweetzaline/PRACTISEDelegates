using System;

namespace Delegates1
{
    public delegate void AddDelegate(int x, int y); //step1
    public delegate string SayDelegate(string str);

    class Program
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string Say(string name)
        {
            return "Hello " + name + "!";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Learnig Delegate Concept!\n");

            Program obj1 = new Program();
            //obj1.Add(100, 20);//called the method by using the instance of the class
           //Step2
            AddDelegate ad = new AddDelegate(obj1.Add);//non static member is called in static method, so we need the instance of the class// Step 2
            //Step3
            ad(100, 200);
            //ad.Invoke(100,200)//automatically generated, if not the upper statement
            //invoke is the method inside the delegate, used to call the method.

            //string obj2=Program.Say("Sweety");/called the method by using the name of the class


            SayDelegate sd = new SayDelegate(Say);//static member can be directly accesed by the classname.
            string str=sd("Sweety");
            // string str= sd.Invoke("Sweety");

            Console.WriteLine(str);
        }
    }
}
