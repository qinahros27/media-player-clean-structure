using MediaPlayer.src.Clean.Entity.Factory;

namespace MediaPlayer.src.Clean.Service.Videos
{
    public interface IVideoService
    {
        public void AddVideo(Video video); 
        public void RemoveVideo(string title,string author);
        public void SeekVideo(string title);
        public void SortVideo(string type);
        public void RemoveAllVideo();
        public void ViewVideoPlaylist();
    }
}