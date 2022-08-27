using System;
namespace DelegateAdd
{
    public class MultiCasteDelegate
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            //Delegate instantiation
            DelOp obj = operation.Add;
            obj += operation.Square;
            obj(5, 5);
            obj(3, 2);
            Console.ReadLine();
        }
        public class operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition={0} \n", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple={0} \n", a * b);
            }
        }
    }
}
