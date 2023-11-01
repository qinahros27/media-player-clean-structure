using MediaPlayer.src.Clean.Entity.Factory;

namespace MediaPlayer.src.Clean.Service.Audios 
{
    public interface IAudioService
    {
        public void AddAudio(Audio audio);
        public void RemoveAudio(string title,string author);
        public void SeekAudio(string title);
        public void SortAudio(string type);
        public void RemoveAllAudio();
        public void ViewAudioPlaylist();
    }
}