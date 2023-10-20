using Bridge.Platforns;
using Bridge.Tramissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLiveAdvanced(new Youtube());
            StartLive(new Facebook());
            StartLive(new Twiter());

            Console.ReadLine();
        }

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");
            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");
            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.SubTitle();
            live.Comments();
            live.Result();
            
        }
    }
}
