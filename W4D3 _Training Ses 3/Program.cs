using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3__Training_Ses_3
{
    public interface IAddition<T>
    {
        T Add(T var1, T var2);
    }
    
    
    public class GenClass : IAddition<int>
    {
        int var1;
        int var2;
     
        

        public int Add(int v1, int v2)
        {
            var1 = v1;
            var2 = v2;
            
            return var1+var2;
            
            

        }
    }

    public class GenClass1 : IAddition<double>
    {
        double var1;
        double var2;
 


        public int Add(int v1, int v2)
        {
            var1 = v1;
            var2 = v2;

            return var1 + var2;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            IAddition<int> genClassInt = new GenClass();
            int i = genClassInt.Add(10, 20);
            Console.WriteLine("the output of the integer operation : " + i);
           
           IAddition<double> genClassDouble = new GenClass1();
            double j = genClassDouble.Add(10.5, 20.5);
            Console.WriteLine("the output of the double operation : " + j);

            Console.ReadLine();
        }
    }
}
