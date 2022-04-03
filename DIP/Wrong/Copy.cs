using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Wrong
{
    public class Copy
    {
        // Burada bu Ketboard ve Printer nesneleri if else cehennemi oluşturmamızı sağlayacak.
        private Keyboard input;
        private Printer output;

        public Copy(Keyboard input, Printer output)
        {
            this.input = input;
            this.output = output;
        }

        public void start()
        {
            Console.WriteLine("Starting copying.");
            //copy();
        }

        //public void copy()
        //{
        //    char ch;
        //    while((int)(ch = input.Read()) != -1)
        //    {
        //        output.Write();
        //        Console.WriteLine(ch);
        //    }


        //}
    }
}
