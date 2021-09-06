using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleconapp
{
    class ObjectDemo
    {
        static void Main(string[] args)
        {
            object data = 123;
            Console.WriteLine("the data typr is " + data.GetType());
            int tempValue = (int)data;
            tempValue += 123;
            data = tempValue;
        }
    }
}
