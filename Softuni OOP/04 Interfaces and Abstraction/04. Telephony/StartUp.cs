using Telephony.Models;
using System;
using Telephony.Interfaces;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            ICall call = new SmartPhone();
            IBrowse browse = new SmartPhone();

            foreach (var number in numbers)
            {
                string numberToCall = call.Call(number);
                Console.WriteLine(numberToCall);
            }

            foreach (var site in sites)
            {
                string siteToBrowse = browse.Browse(site);
                Console.WriteLine(siteToBrowse);
            }
        }
    }
}
