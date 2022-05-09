using Bridge.Platforms;
using Bridge.Transmissions;
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
            StartLiveAdvanced(new YouTube());
            StartLive(new Facebook());
            StartLive(new Twitch());
            StartLiveAdvanced(new DLive());

            Console.ReadLine();
        } 

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();

            live.Result();

            Console.WriteLine();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvandeceLive live = new AdvandeceLive(platform);

            live.Broadcasting();
            live.Subtitles();
            live.Comments();
            live.Record();
            live.Result();

            Console.WriteLine();
        }
    }
}
