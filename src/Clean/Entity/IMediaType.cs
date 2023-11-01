namespace MediaPlayer.src.Clean.Entity
{
    public interface IMediaType 
    {
        void Play(string currentPosition);
        void Pause(string currentPosition);
        void Stop(string currentPosition);
        void Seek();
    }
}