namespace MediaPlayer.src.Clean.Entity.Observer
{
    public class Subcriber : ISubcriber
    {
        public string User { get; set; }
        public Subcriber(string user, ISubject subject)
        {
            User = user;
            subject.RegisterSubcribers(this);
        }
 
        public void update(string playbackEvent)
        {
            Console.WriteLine($"Hello {User}, {playbackEvent}");
        }
    }
}