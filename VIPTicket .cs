using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public double VIPFee { get; set; }

        public VIPTicket(string movie, double price, bool lounge, double fee)
            : base(movie, price)
        {
            LoungeAccess = lounge;
            VIPFee = fee;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{Id}] {MovieName} | VIP | Lounge: {LoungeAccess} | Fee: {VIPFee} | Price: {Price} | After Tax: {PriceAfterTax()} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess, VIPFee);
        }
    }
}
