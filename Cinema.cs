using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cinema
    {
        private List<IPrintable> tickets = new List<IPrintable>();

        public void Open() => Console.WriteLine("=== Cinema Opened ===");
        public void Close() => Console.WriteLine("=== Cinema Closed ===");

        public void AddTicket(IPrintable ticket)
        {
            tickets.Add(ticket);
        }

        public void PrintAll()
        {
            Console.WriteLine("--- All Tickets ---");
            foreach (var t in tickets)
                t.Print();
        }
    }
}
