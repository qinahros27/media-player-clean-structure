using MediaPlayer.src.Clean.Entity.Factory;
using MediaPlayer.src.Clean.Entity;

namespace MediaPlayer.src.Clean.Service.Videos 
{
    public class VideoService : IVideoService 
    {
        private IMediaPlayers _mediaPlayers;

        public VideoService(IMediaPlayers mediaPlayers) 
        {
            _mediaPlayers = mediaPlayers;
        }

        public void AddVideo(Video video)
        {
            _mediaPlayers.AddVideo(video);
        }

        public void RemoveVideo(string title,string author)
        {
            _mediaPlayers.RemoveVideo(title,author);
        }

        public void SeekVideo(string title)
        {
            _mediaPlayers.SeekVideo(title);
        }

        public void SortVideo(string type)
        {
            _mediaPlayers.SortVideo(type);
        }

        public void RemoveAllVideo()
        {
            _mediaPlayers.RemoveAllVideo();
        }

        public void ViewVideoPlaylist()
        {
            _mediaPlayers.ViewVideoPlaylist();
        }
    }
}