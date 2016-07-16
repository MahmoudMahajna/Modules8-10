using System;

namespace MailSystem
{
    public class MailManager
    {
        public event EventHandler<MailArrivedEventArgs> MailArrived;

        protected virtual void OnMailArrived(MailArrivedEventArgs e)
        {
            MailArrived?.Invoke(this, e);
        }

        public void SimulateMailArrived()
        {
            OnMailArrived(new MailArrivedEventArgs("Hello","Hello my friend"));
        }
    }
}