using System;
using TimeEvent;

namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            TimeSender sender = new TimeSender();

            TimeReceiver receiver1 = new TimeReceiver();
            TimeReceiver receiver2 = new TimeReceiver();

            receiver1.Register(sender);
            receiver2.Register(sender);

            sender.SendMailTimed(1000);

            while(receiver1.MessageInfo == null && receiver2.MessageInfo == null) { }

            Console.WriteLine(receiver1.MessageInfo);
            Console.WriteLine(receiver2.MessageInfo);
        }
    }
}
