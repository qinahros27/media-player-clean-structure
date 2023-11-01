using MediaPlayer.src.Clean.Entity.Factory;
using MediaPlayer.src.Clean.Entity;

namespace MediaPlayer.src.Clean.Service.Audios 
{
    public class AudioService : IAudioService 
    {
        private IMediaPlayers _mediaPlayers;

        public AudioService(IMediaPlayers mediaPlayers) 
        {
            _mediaPlayers = mediaPlayers;
        }

        public void AddAudio(Audio audio)
        {
            _mediaPlayers.AddAudio(audio);
        }
        
        public void RemoveAudio(string title,string author)
        {
            _mediaPlayers.RemoveAudio(title,author);
        }

        public void SeekAudio(string title)
        {
            _mediaPlayers.SeekAudio(title);
        }

        public void SortAudio(string type)
        {
            _mediaPlayers.SortAudio(type);
        }

        public void RemoveAllAudio()
        {
            _mediaPlayers.RemoveAllAudio();
        }

        public void ViewAudioPlaylist()
        {
            _mediaPlayers.ViewAudioPlaylist();
        }
    }
}