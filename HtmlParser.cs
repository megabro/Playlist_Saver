using System;
using System.Collections.Generic;
using System.IO;

namespace Playlist_Saver
{
    internal class HtmlParser : List<PlaylistItem>
    {
        private const int LabelOffset = 12;
        
        public HtmlParser(List<string> paths)
        {
            foreach (var path in paths)
            {
                var lines = File.ReadAllLines(path);
                
                foreach (var line in lines)
                {
                    if (!line.Contains("title=") || !line.Contains("aria-label=")) continue;

                    int lineStart = line.IndexOf("aria-label");
                    lineStart += LabelOffset;
                    
                    var tempStr = line.Substring(lineStart);
                    tempStr = tempStr.Substring(0, tempStr.IndexOf('"'));

                    var outputItem = new PlaylistItem(tempStr, null, null, null);
                    
                    Add(outputItem);
                }
            }
        }
    }
}