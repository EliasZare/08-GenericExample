using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_GenericExample
{
    public class GenricClass<T, TKey> where T : class where TKey : Test
    {
        public T Salary { get; set; }
        public T MyProperty { get; set; }
    }


    public static class GenricMethods
    {
        public static void GenricMethod<T>(T obj) where T : Test
        {
            Console.WriteLine(obj.MyProperty);
        }
    }
}
    
    
