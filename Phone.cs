using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LiliyaBukhtik
{
    internal class Phone
    {
        public string number = "+79776221400";
        public string model = "SamsungSM_N975F";
        public string weight = "33";

        public void ReceiveCall(string name)
        {
            Console.WriteLine("Calling {0}", name);
        }


        public string GetNumber()
        { return number; }

        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine("Calling {0} number {1}", name, number);
        }

        public void SendMessage(params string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine($"Message sent {numbers[i]}");

        }
    }
}
