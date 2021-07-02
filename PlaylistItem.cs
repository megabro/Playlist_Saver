namespace Playlist_Saver
{
    public struct PlaylistItem
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
            throw new System.NotImplementedException();
        }
    }
}