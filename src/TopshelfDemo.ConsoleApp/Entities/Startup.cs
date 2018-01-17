using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopshelfDemo.ConsoleApp.Entities
{
    public class Startup
    {
        readonly System.Timers.Timer _timer;

        public Startup()
        {
            _timer = new System.Timers.Timer( /* ConverterMinToMiliseconds(1) */ ) { AutoReset = false };
            _timer.Elapsed += (sender, eventArgs) => Run();
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void Run()
        {
            //do something!
            Console.WriteLine();
            Console.WriteLine(new String('*', 50));
            Console.WriteLine("Hello World!");
            Console.WriteLine(new String('*', 50));
        }

        public double ConverterMinToMiliseconds(double valor)
        {
            return valor * 60000;
        }
    }
}
