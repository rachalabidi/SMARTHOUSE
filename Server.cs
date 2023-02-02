using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System;

sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(8085);
            ChannelServices.RegisterChannel(ch);



            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server.Impl),
                                                               "obj",
                                                             WellKnownObjectMode.Singleton);
            //SingleCall
            Console.Write("Sever is  Ready........");
            Console.Read();
        }

    }
}