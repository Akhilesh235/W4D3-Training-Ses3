using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D3__Training_Ses_3
{
    public class GenClass<T> where T : 
    {
        T var1;
        T var2;
        T addition;
        List<T> var3 = new List<T>();

        public T Add(T v1, T v2)
        {
            var1 = v1;
            var2 = v2;
            var3.Add(var1);
            var3.Add(var2);
            addition = v1 + v2;
            int count = var3.Where((x) => 10 > 20).Count();
            return var1;
            
            

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            GenClass<int> genClassInt = new GenClass<int>();
            int i = genClassInt.Add(10, 20);
            Console.WriteLine("the output of the integer operation : " + i);
           
            GenClass<double> genClassDouble = new GenClass<double>();
            int j = genClassInt.Add(10.5, 20.5);
            Console.WriteLine("the output of the double operation : " + j);

            Console.ReadLine();
        }
    }
}
