using System;

namespace Playlist_Saver
{
    public class PlaylistItem
    {
        public PlaylistItem(string title, string id, string length, string uploadDate)
        {
            Title = title;
            Id = id;
            Length = length;
            UploadDate = uploadDate;
        }

        public string Title { get; private set; }
        public string Id { get; private set; }
        public string Length { get; private set; }
        public string UploadDate { get; private set; }

        // Should print out all the properties of the item (title, id, length, upload date)
        public void FormatedPrint()
        {
            //Console.WriteLine("{0} ({1}), {2}, {3} ", Title, Id, Length, UploadDate);
            PrintTitle();
            PrintId();
            PrintLength();
            PrintUpDate();
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