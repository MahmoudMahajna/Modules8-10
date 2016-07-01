using System;

namespace MailSystem
{
    public class MailArrivedEventArgs:EventArgs
    {
        public string Title { get; }
        public string Body { get; }

        public MailArrivedEventArgs(string title,string body)
        {
            Title = title;
            Body = body;
        }
    }
}