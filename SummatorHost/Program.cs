using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SummatorRemoteService;

namespace SummatorHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new TcpChannel(51494);
            ChannelServices.RegisterChannel(channel);

            var service = new SummatorRemoteService.SummatorRemoteService();
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(SummatorRemoteService.SummatorRemoteService),
                "Summator", WellKnownObjectMode.SingleCall);
            Console.WriteLine("Serv is on");
            Console.ReadKey();
        }
    }
}
