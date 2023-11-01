using MediaPlayer.src.Clean.Entity.Factory;
using MediaPlayer.src.Clean.Service.Audios;

namespace MediaPlayer.src.Clean.Controller 
{
    public class AudioController
    {
        private IAudioService _audioService;

        public AudioController(IAudioService audioService)
        {
            _audioService = audioService;
        }

        public void AddAudio(Audio audio) 
        {
            _audioService.AddAudio(audio);
        }

        public void RemoveAudio(string title, string author)
        {
            _audioService.RemoveAudio(title,author);
        }

        public void SeekAudio(string title)
        {
            _audioService.SeekAudio(title);
        }

        public void SortAudio(string type)
        {
            _audioService.SortAudio(type);
        }

        public void RemoveAllAudio()
        {
            _audioService.RemoveAllAudio();
        }

        public void ViewAudioPlaylist()
        {
            _audioService.ViewAudioPlaylist();
        }
    }
}