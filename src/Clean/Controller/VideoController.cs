using MediaPlayer.src.Clean.Entity.Factory;
using MediaPlayer.src.Clean.Service.Videos;

namespace MediaPlayer.src.Clean.Controller 
{
    public class VideoController
    {
        private IVideoService _videoService;
        
        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        public void AddVideo(Video video)
        {
            _videoService.AddVideo(video);
        }

        public void RemoveVideo(string title,string author)
        {
            _videoService.RemoveVideo(title,author);
        }

        public void SeekVideo(string title)
        {
            _videoService.SeekVideo(title);
        }

        public void SortVideo(string type)
        {
            _videoService.SortVideo(type);
        }

        public void RemoveAllVideo()
        {
            _videoService.RemoveAllVideo();
        }

        public void ViewVideoPlaylist()
        {
            _videoService.ViewVideoPlaylist();
        }
    }
}