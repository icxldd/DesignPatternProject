using System;
using PrototypePattern.Core;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket() {Name = "程先龙", Age = 21};

            Ticket cloneTicket = ticket.Clone();

            Ticket eqTicket = ticket;
            if (ticket.GetHashCode() == cloneTicket.GetHashCode())
            {
                Console.WriteLine("1_是相同的对象");
            }


            if (ticket.GetHashCode() == eqTicket.GetHashCode())
            {
                Console.WriteLine("2_是相同的对象");
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}