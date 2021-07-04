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

            Id = null;
        }

        private void PrintTitle()
        {
            Console.Write(Title);
        }
        
        private void PrintId()
        {
            if (Id != null)
            {
                Console.Write("({0})", Id);
            }
        }
        
        private void PrintLength()
        {
            Console.Write(Length);
        }
        
        private void PrintUpDate()
        {
            Console.Write(UploadDate);
        }
    }
}