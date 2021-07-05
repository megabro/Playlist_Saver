using System;
using System.Collections.Generic;
using System.Linq;

namespace Playlist_Saver
{
    class Program
    {
        private static void Usage()
        {
            Console.WriteLine("Usage: playlist_saver [--html] <html files>");
            Console.WriteLine("       playlist_saver [--ytAPI] <playlist name>");
        }
        
        static void Main(string[] args)
        {
            if (args.Length is < 1 or > 2)
            {
                Usage();
                return;
            }

            var outputList = new List<PlaylistItem>();

            var argList = new List<string>(args);
            
            var options = argList.FindAll(k => k.StartsWith("--"));
            argList = argList.Except(options).ToList();
            
            if (options.Count != 1)
            {
                Usage();
                return;
            }

            //arg "html" or "ytapi"
            switch (options[0])
            {
                case "--html":
                    //HTML impl
                    outputList = new HtmlParser(argList);
                    break;
                case "--ytAPI":
                    //ytAPI impl
                    outputList = new YTParser(argList);
                    break;
                default:
                    Usage();
                    break;
            }

            //Output list to console
            outputList.ForEach(k => k.FormatedPrint());
        }
    }
}