using System;

namespace enquiry_form
{
    class Program
    {
        private string name, fathername, mothername, contactno, emailid, coursename,gender,pincode,doj,bt;
        public string Enquir()
        {
            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.Write("Enter Gender:");
            gender = Console.ReadLine();
            Console.Write("Enter Father Name:");
            fathername = Console.ReadLine();
            Console.Write("Enter Mother Name:");
            mothername = Console.ReadLine();
            Console.Write("Enter Pincode:");
            pincode = Console.ReadLine();
            Console.Write("Enter Contact No:");
            contactno = Console.ReadLine();
            Console.Write("Enter Email Id:");
            emailid = Console.ReadLine();
            Console.WriteLine("********Course Details********");
            Console.Write("Enter Coursename:");
            coursename = Console.ReadLine();
            Console.Write("Date of Joining:");
            doj = Console.ReadLine();
            Console.WriteLine("\n");
            return invoice();
        }

        public string invoice()
        {
            string x = "\t*******SIDDHAKALA*******\n" + "INSTITUTE OF INFORMATION TECHNOLOGY\n\t" + "Receipt\n\t" + "-----------------------------------------\n Registration No:1\t\t Date:"+DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt") +"\n Received with thanks from Mr."+name+"\n The Sum of 'Rs 50000' in  words 'Five Thousand Rupees Only /-'";
            return x;


        }
        
    }
}
