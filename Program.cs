using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//single delegate can be applied to multiple methods
//delegates are used to encapsulate methods means instead of callling my method directly we have given the responsibilty to the deligate to call the method by using Invoke()
//delegate and method both must have same return type(in the case below it is of void return type)

namespace Delegates2
{
    //first create methods in class Program and then create delegate here having same signature
    //make delegate
    public delegate void Calc(int a, int b);    //make method and delegate have same signature

        
    class Program
    {
        //1 method
        public static void Add(int a, int b)     //make method and delegate have same signature
        {
            int c = a + b;
            Console.WriteLine("{0}", c);
        }

        //single delegate can be applied to multiple methods

        //1 method
        public static void Sub(int a, int b)     //make method and delegate have same signature
        {
            int c = a - b;
            Console.WriteLine("{0}", c);
        }

     



        static void Main(string[] args)
        {
            //make object of delegate
            Calc cc = new Calc(Program.Add);   //pass the class.method in it
            //method reference is passed in delegate object

            //call by invoke()
            cc.Invoke(10,20); //passing values of parameters

            //same delegate object can call multiple methods
            cc = Sub;  //passing sub in delegate now
            cc.Invoke(20,5);  //calling

            Console.ReadLine();
            //overall -Cal delegate having multiple methods like add,sub
        }
    }


}
