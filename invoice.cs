using System;
using System.Collections.Generic;
using System.Text;

namespace enquiry_form
{
    class invoice
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            var message = p.Enquir();
            Console.WriteLine(message);
        }
    }
}
