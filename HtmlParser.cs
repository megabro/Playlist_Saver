using System;
using System.Collections.Generic;
using System.IO;

namespace Playlist_Saver
{
    internal static class HtmlParser
    {
        private const int LabelOffset = 12;
        
        public static List<PlaylistItem> Parse(List<string> paths)
        {
            List<PlaylistItem> outputList = new List<PlaylistItem>();
            
            foreach (var path in paths)
            {
                var lines = File.ReadAllLines(path);

                
                foreach (var line in lines)
                {
                    if (!line.Contains("title=") || !line.Contains("aria-label=")) continue;

                    int lineStart = line.IndexOf("aria-label", StringComparison.Ordinal);
                    lineStart += LabelOffset;
                    
                    var tempStr = line.Substring(lineStart);
                    tempStr = tempStr.Substring(0, tempStr.IndexOf('"'));

                    var outputItem = new PlaylistItem(tempStr, "unknown", "unknown", "unknown");
                    
                    outputList.Add(outputItem);
                }
                
            }

            return outputList;
        }
    }
}