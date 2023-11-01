namespace MediaPlayer.src.Clean.Entity.Observer 
{
    public interface ISubcriber
    {
        void update(string playbackEvent);
    }
}