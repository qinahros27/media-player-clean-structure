using MediaPlayer.src.Clean.Entity.Observer;

namespace MediaPlayer.src.Clean.Entity.Factory 
{
    public class Audio : MediaType, IMediaType , ISubject
    {
        private string _playbackEvent { get; set; }
        private List<ISubcriber> subcribers = new List<ISubcriber>();
        public Audio(string title, string author, string currentPosition, string duration): base(title,author,currentPosition,duration) {}

        public void setEvent(string playbackEvent)
        {
            this._playbackEvent = playbackEvent;
            NotifySubcribers();
        }
        
        public void Play(string currentPosition) 
        {
            CurrentPosition = currentPosition;
            setEvent($"The audio file named {Title} has a duration of {Duration} and is playing at {CurrentPosition}.");
        }

        public void Pause(string currentPosition) 
        {
            CurrentPosition = currentPosition;
            setEvent($"The audio file named {Title} has a duration of {Duration} and is pausing at {CurrentPosition}.");
        }

        public void Stop(string currentPosition) 
        {
            CurrentPosition = currentPosition;
            setEvent($"The audio file named {Title} has a duration of {Duration} and is stoping at {CurrentPosition}.");
        }

        public void Seek() 
        {
            Console.WriteLine($"The audio file named {Title} is seeking.");
        }

        public void RegisterSubcribers(ISubcriber subcriber)
        {
            Console.WriteLine($"Subcriber named {((Subcriber)subcriber).User} is added.");
            subcribers.Add(subcriber);
        }

        public void RemoveSubcribers(ISubcriber subcriber) 
        {
            Console.WriteLine($"Subcriber named {((Subcriber)subcriber).User} is removed.");
            subcribers.Remove(subcriber);
        }

        public void NotifySubcribers()
        {
            Console.WriteLine();
            foreach (ISubcriber subcriber in subcribers)
            {
                subcriber.update(_playbackEvent);
            }
        }
    }
}