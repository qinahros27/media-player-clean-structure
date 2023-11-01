namespace MediaPlayer.src.Clean.Entity
{
    public class MediaType
    {  
        private readonly int _id = 0; 
        private string _title = string.Empty;
        private string _author = string.Empty;
        private string _currentPosition = string.Empty;
        private string _duration = string.Empty;

        public MediaType(string title, string author, string currentPosition,string duration) 
        {
            _id++;
            _title = title;
            _author = author;
            _currentPosition = currentPosition;
            _duration = duration;
        }

        public int Id 
        {
            get{return _id;}
        }

        public string Title 
        {
            set{_title = value;}
            get{return _title;}
        } 

        public string Author
        {
            set{_author = value;}
            get{return _author;}
        }

        public string CurrentPosition
        {
            set{_currentPosition = value;}
            get{return _currentPosition;}
        }

        public string Duration
        {
            set{_duration = value;}
            get{return _duration;}
        }
    }
}