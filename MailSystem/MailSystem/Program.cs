using System;
using System.Threading;


namespace MailSystem
{
    class Program
    {
        private static void Main()
        {
            var mailManager=new MailManager();
            mailManager.MailArrived += delegate(object o, MailArrivedEventArgs e)
            {
                Console.WriteLine("Title:");
                Console.WriteLine(e.Title);
                Console.WriteLine("Body:");
                Console.WriteLine(e.Body);
            };
            mailManager.SimulateMailArrived();

            var timer = new Timer(delegate { mailManager.SimulateMailArrived(); },null,0,1000);
            Console.Read();
        }
    }
}
