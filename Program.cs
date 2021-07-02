using System;
using System.IO;

namespace Playlist_Saver
{
    class Program
    {
        private static void Usage()
        {
            Console.WriteLine("Usage: playlist_saver [--html] [--ytAPI] <html file>");
        }
        
        //pl_saver 
        static void Main(string[] args)
        {
            if (args.Length is < 1 or > 2)
            {
                Usage();
                return;
            }

            switch (args[0])
            {
                case "--html":
                    //HTML impl
                    break;
                case "--ytAPI":
                    //ytAPI impl
                    break;
                default:
                    Usage();
                    break;
            }

            //Output list to console
            Console.WriteLine("test");
        }
    }
}