using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPrograms
{
    //declaration of delegate
    public delegate int MyDelegate(int a, int b);
    public class Calc
    {
       
        public int Add(int a, int b)
        { 
            return a + b;   
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            Calc calc=new Calc();
            MyDelegate del=new MyDelegate(calc.Sub);//add method reference
            del += new MyDelegate(calc.Add);
            del += new MyDelegate(calc.Multiply);

            // invcation list
            Delegate[] list=del.GetInvocationList();
            foreach (Delegate item in list) 
            {
                Console.WriteLine(item.Method);
            }
        }
    }
}
