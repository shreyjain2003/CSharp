using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Oops
{
    interface ILoggable { void Log(string message); }
    interface INotifiable { void Notify(string message); }

    abstract class ServiceBase
    {
        protected string ServiceName { get; }
        protected ServiceBase(string serviceName) => ServiceName = serviceName;

        public void Start() => Console.WriteLine($"{ServiceName} started.");
        public abstract void Execute();
    }

    class EmailService : ServiceBase, ILoggable, INotifiable
    {
        public EmailService() : base("EmailService") { }

        public override void Execute()
        {
            Log("Executing email pipeline...");
            Notify("Email batch started");
            Console.WriteLine("Sending emails...");
        }

        public void Log(string message) => Console.WriteLine($"[LOG] {message}");
        public void Notify(string message) => Console.WriteLine($"[NOTIFY] {message}");
    }
}

// The following code should be inside a Main method in a Program class
class Abstract_and_Interface
{
    public static void Main()
    {
        var svc = new Capgemini_Training.Oops.EmailService();
        svc.Start();
        svc.Execute();
    }
}
