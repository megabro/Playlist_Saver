using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Playlist_Saver
{
    class Program
    {
        private static void Usage()
        {
            Console.WriteLine("Usage: playlist_saver [--html] <html file>");
            Console.WriteLine("       playlist_saver [--ytAPI] <playlist name>");
        }
        
        //pl_saver 
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

            // string "html" or "ytapi"
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