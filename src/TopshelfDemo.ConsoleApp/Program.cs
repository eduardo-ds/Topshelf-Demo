using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using TopshelfDemo.ConsoleApp.Entities;

namespace TopshelfDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(r =>
            {
                r.Service<Startup>(s =>
                {
                    s.ConstructUsing(name => new Startup());
                    s.WhenStarted(ws => ws.Start());
                    s.WhenStopped(ws => ws.Stop());
                });

                r.RunAsLocalSystem();

                r.SetDescription("Descricao do windows service");
                r.SetDisplayName("Nome de exibicao windows service");
                r.SetServiceName("Nome do windows service");

            });
        }
    }
}
