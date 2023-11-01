using MediaPlayer.src.Clean.Entity.Factory;

namespace MediaPlayer.src.Clean.Entity
{
    public interface IMediaPlayers 
    {
        public void AddAudio(Audio audio);
        public void RemoveAudio(string title,string author);
        public void SeekAudio(string title);
        public void SortAudio(string type);
        public void RemoveAllAudio();
        public void ViewAudioPlaylist();
        public void AddVideo(Video video); 
        public void RemoveVideo(string title,string author);
        public void SeekVideo(string title);
        public void SortVideo(string type);
        public void RemoveAllVideo();
        public void ViewVideoPlaylist();
    }
}