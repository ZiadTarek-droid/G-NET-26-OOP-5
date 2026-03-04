using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movie, double price, bool is3D)
            : base(movie, price)
        {
            Is3D = is3D;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{Id}] {MovieName} | IMAX | 3D: {Is3D} | Price: {Price} | After Tax: {PriceAfterTax()} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new IMAXTicket(MovieName, Price, Is3D);
        }
    }
}
