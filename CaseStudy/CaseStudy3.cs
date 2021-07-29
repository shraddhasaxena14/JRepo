using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaseStudy3
{
    class UserString
    {
        void StringFunction()
        {

            // char charcount;
            string s;
            Console.WriteLine("Enter your string");
            s = Console.ReadLine();
            Console.WriteLine("TO UPPER:{0} ", arg0: s.ToUpper());
            Console.WriteLine("TO LOWER:{0} ", s.ToLower());
            Console.WriteLine("Length :{0}", s.Length);
            var count = s.Count(Char.IsDigit);
            Console.WriteLine("Count of digit:{0}", count);
        }

        static void Main()
        {
            UserString userstring = new UserString();
            userstring.StringFunction();
        }
    }
}

