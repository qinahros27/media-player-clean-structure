using MediaPlayer.src.Clean.Entity.Factory;
using MediaPlayer.src.ErrorHelper;
using MediaPlayer.src.Clean.Entity;

namespace MediaPlayer.src.Clean.Infrastructure.Singleton 
{
    public class MediaPlayers : IMediaPlayers
    {
        private static MediaPlayers instance = null;
        private List<Audio> _audio;
        private List<Video> _video;

        public MediaPlayers() 
        {
            _audio = new List<Audio>();
            _video = new List<Video>();
        }

        public static MediaPlayers GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new MediaPlayers();
                return instance;
            }
        }

        public void AddAudio(Audio audio) 
        {
            var checkExisted = _audio.FirstOrDefault(a => a.Title == audio.Title && a.Author == audio.Author);
            if(checkExisted != null) 
            {
                throw ErrorHandler.FileExisted();
            }
            else 
            {
                _audio.Add(audio);
                Console.WriteLine($"Audio named {audio.Title} is added to list.");
            }
        }

        public void RemoveAudio(string title, string author) 
        {
            var findAudio = _audio.FirstOrDefault(a => a.Title == title && a.Author == author);
            if(findAudio != null) 
            {
                _audio.Remove(findAudio);
                Console.WriteLine($"Audio named {findAudio.Title} is removed from list.");
            }
            else 
            {
                throw ErrorHandler.FileNotExist();
            }
        }

        public void SeekAudio(string title)
        {
            //Check if there is at least one audio has this title in the list
            var findAudio = _audio.FirstOrDefault(a => a.Title == title);
            if(findAudio != null) 
            {
                Console.WriteLine($"The results of the audio file named {title}");
                foreach(var a in _audio) 
                {
                    if(a.Title == title) 
                    {
                        Console.WriteLine($"Title: {a.Title}; Author: {a.Author}");
                    }
                }
            }
            else 
            {
                throw ErrorHandler.FileNotExist();
            }
        }

        public void SortAudio(string type) 
        {
            List<Audio> sort = new List<Audio>();
            if(type == "title") 
            {
                sort = _audio.OrderBy(a => a.Title).ToList();
                Console.WriteLine("Audio file sorted by title");
            }
            else if(type == "author")
            {
                sort = _audio.OrderBy(a => a.Author).ToList();
                Console.WriteLine("Audio file sorted by author");
            }
            foreach(var s in sort)
            {
                Console.WriteLine($"Title: {s.Title}; Author:{s.Author}; Duration: {s.Duration}");
            }
        }
        
        public void RemoveAllAudio() 
        {
            _audio.Clear();
        }

        public void ViewAudioPlaylist() 
        {
            foreach(var a in _audio) 
            {
                Console.WriteLine($"Title: {a.Title}; Author:{a.Author}; Duration: {a.Duration}");
            }
        }

        public void AddVideo(Video video) 
        {
            var checkExisted = _video.FirstOrDefault(v => v.Title == video.Title && v.Author == video.Author);
            if(checkExisted != null) 
            {
                throw ErrorHandler.FileExisted();
            }
            else 
            {
                _video.Add(video);
                Console.WriteLine($"Video named {video.Title} is added to list.");
            }
        }

        public void RemoveVideo(string title,string author) 
        {
            var findVideo = _video.FirstOrDefault(v => v.Title == title && v.Author == author);
            if(findVideo != null) 
            {
                _video.Remove(findVideo);
                Console.WriteLine($"Video named {findVideo.Title} is removed from list.");
            }
            else 
            {
                throw ErrorHandler.FileNotExist();
            }
        }

        public void SeekVideo(string title)
        {
            //Check if there is at least one video has this title in the list
            var findVideo = _video.FirstOrDefault(v => v.Title == title);
            if(findVideo != null) 
            {
                Console.WriteLine($"The results of the video file named {title}");
                foreach(var v in _video) 
                {
                    if(v.Title == title) 
                    {
                        Console.WriteLine($"Title: {v.Title}; Author: {v.Author}");
                    }
                }
            }
            else 
            {
                throw ErrorHandler.FileNotExist();
            }
        }

        public void SortVideo(string type) 
        {
            List<Video> sort = new List<Video>();
            if(type == "title") 
            {
                sort = _video.OrderBy(v => v.Title).ToList();
                Console.WriteLine("Video file sorted by title");
            }
            else if(type == "author")
            {
                sort = _video.OrderBy(v => v.Author).ToList();
                Console.WriteLine("Video file sorted by author");
            }
            foreach(var s in sort)
            {
                Console.WriteLine($"Title: {s.Title}; Author:{s.Author}; Duration: {s.Duration}");
            }
        }

        public void RemoveAllVideo() 
        {
            _video.Clear();
        }

        public void ViewVideoPlaylist() 
        {
            foreach(var v in _video)
            {
                Console.WriteLine($"Title: {v.Title}; Author:{v.Author}; Duration: {v.Duration}");
            }
        }
    }
}