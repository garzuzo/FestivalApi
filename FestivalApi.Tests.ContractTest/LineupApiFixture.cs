using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalApi.Tests.ContractTest
{
    public class LineupApiFixture: IDisposable
    {
        private readonly IHost server;
        public Uri ServerUri { get; }

        public LineupApiFixture()
        {
            ServerUri = new Uri("http://localhost:9223");
            server = Host.CreateDefaultBuilder()
                         .ConfigureWebHostDefaults(webBuilder =>
                         {
                             webBuilder.UseUrls(ServerUri.ToString());
                             webBuilder.UseStartup<TestStartup>();
                         })
                         .Build();
            server.Start();
        }

        public void Dispose()
        {
            server.Dispose();
        }
    }
}
