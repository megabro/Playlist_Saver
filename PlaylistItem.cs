using System;

namespace Playlist_Saver
{
    public class PlaylistItem
    {
        public enum PrintMode
        {
            Minimal,
            Full
        }
        
        public PlaylistItem(string title, string id, string length, string uploadDate, string channelTitle)
        {
            Title = title;
            Id = id;
            Length = length;
            UploadDate = uploadDate;
            ChannelTitle = channelTitle;
        }

        private string Title { get; set; }
        private string Id { get; set; }
        private string Length { get; set; }
        private string UploadDate { get; set; }
        private string ChannelTitle { get; set; }
        
        // Should print out all the properties of the item (title, id, length, upload date)
        public void FormatedPrint(PrintMode mode)
        {
            //Console.WriteLine("{0} ({1}), {2}, {3} ", Title, Id, Length, UploadDate);
            switch (mode)
            {
                case PrintMode.Full:
                    PrintTitle();
                    PrintId();
                    PrintChannelTitle();
                    PrintLength();
                    PrintUpDate();
                    break;
                case PrintMode.Minimal:
                    PrintTitle();
                    PrintId();
                    PrintLength();
                    break;
                default:
                    Console.WriteLine("Error: incorrect PrintMode specified.");
                    break;
            }
            
            Console.Write("\n");
        }

        private void PrintTitle()
        {
            if (Title != null) Console.Write("{0}", Title);
        }

        private void PrintId()
        {
            if (Id != null) Console.Write(" ({0})", Id);
        }

        private void PrintChannelTitle()
        {
            if (Id != null) Console.Write(" ({0})", ChannelTitle);
        }

        private void PrintLength()
        {
            if (Length != null) Console.Write(" {0}", Length);
        }

        private void PrintUpDate()
        {
            if (UploadDate != null) Console.Write(" {0}", UploadDate);
        }
    }
}