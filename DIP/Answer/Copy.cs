using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Answer
{
    public class Copy
    {
        private Reader input;
        private Writer output;

        public Copy(Reader input, Writer output)
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
        //    while((int)(ch = input.Read()) != '0')
        //        output.Write(ch);
        //    input.Close();
        //    output.Close();
        //    Console.WriteLine("Stop Copying.");
        //}
    }
}
