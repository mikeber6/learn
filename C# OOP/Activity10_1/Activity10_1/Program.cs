using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                Person person = new Person();

                foreach (string s in person.GetPersonList("z"))
                {
                    Console.WriteLine(s);
                }
                                
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
