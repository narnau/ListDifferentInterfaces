using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableDifferentInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var authorisedDealer = new AuthorisedDealer();
            authorisedDealer.ListProperties();
            Console.ReadLine();
        }
    }
}
