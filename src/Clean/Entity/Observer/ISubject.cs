namespace MediaPlayer.src.Clean.Entity.Observer
{
    public interface ISubject
    {
        void RegisterSubcribers(ISubcriber subcriber);
        void RemoveSubcribers(ISubcriber subcriber);
        void NotifySubcribers();
    }
}