using System;

namespace DelegateAdd
{
    //Delegate Defination or Declaration
    public delegate int operation(int x, int y);

    class Program
    {
        //Method that passes as an Argument
        //It has same signature as Delegates
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate POC!");
            //Delegate instantiation
            operation obj = new operation(Addition);
            //output
            Console.WriteLine("Addition is ={0} \n", obj(23, 24));
            MultiCasteDelegate.ImplementDelegate();
        }
    }
}
