﻿using MediaPlayer.src.Clean.Entity.Factory;
using MediaPlayer.src.Clean.Entity.Observer;
using MediaPlayer.src.Clean.Infrastructure.Singleton;

namespace MediaPlayer.src.Clean.Infrastructure 
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool open = true;

            MediaPlayers mediaPlayer = MediaPlayers.GetInstance;

            Audio audio1 = new Audio("What It Is","Doechii","00:00", "3:08");
            Audio audio2 = new Audio("Still Life", "BIGBANG", "00:00", "3.06");
            Audio audio3 = new Audio("Tomboy","Destiny Rogers","00:00", "3:22");

            Video video1 = new Video("Move","Treasure","00:00","3:41");
            Video video2 = new Video("Over Me","Zerobaseone","00:00","3:14");
            Video video3 = new Video("Tomboy","(G)I-DLE","00:00","3:06");

            Subcriber sub1 = new Subcriber("Anh Nguyen",audio1);
            Subcriber sub2 = new Subcriber("Rose Nguyen",video1);
            Subcriber sub3 = new Subcriber("Hanna", audio2);
            Subcriber sub4 = new Subcriber("Helen", video2);
            
            video2.RemoveSubcribers(sub4);

            while(open) 
            {
                Console.WriteLine("1. Listen to music");
                Console.WriteLine("2. Watch video music");
                Console.WriteLine("3. Manage music playlist");
                Console.WriteLine("4. Manage video playlist");
                Console.Write("Welcome to AnhMp3. Choose an option(1-4). Press E to exit: ");
                string input = Console.ReadLine();
 
                if(input == "1") 
                {
                    bool playAudio = true;
                    while(playAudio) 
                    {
                        Console.WriteLine("audio1");
                        Console.WriteLine("audio2");
                        Console.WriteLine("audio3");
                        Console.Write("There are three audio available. Choose an audio(press E to exit): ");
                        string audio = Console.ReadLine();

                        if(audio == "audio1") 
                        {
                            PlayAudio(audio1, ChooseOption());
                        }
                        else if(audio == "audio2")
                        {
                            PlayAudio(audio2, ChooseOption());
                        }
                        else if(audio == "audio3") 
                        {
                            PlayAudio(audio3, ChooseOption());
                        }
                        else if(audio == "E")
                        {
                            playAudio = false;
                        }
                        else 
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                }
                else if (input == "2")
                {
                    bool playVideo = true;
                    while(playVideo) 
                    {
                        Console.WriteLine("video1");
                        Console.WriteLine("video2");
                        Console.WriteLine("video3");
                        Console.Write("There are three videos available. Choose a video(press E to exit): ");
                        string video = Console.ReadLine();

                        if(video == "video1") 
                        {
                            PlayVideo(video1, ChooseOption());
                        }
                        else if(video == "video2")
                        {
                            PlayVideo(video2, ChooseOption());
                        }
                        else if(video == "video3") 
                        {
                            PlayVideo(video3, ChooseOption());
                        }
                        else if(video == "E")
                        {
                            playVideo = false;
                        }
                        else 
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                }
                else if (input == "3")
                {
                    bool manageAudio = true;
                    while(manageAudio) 
                    {
                        Console.WriteLine("1. Add an audio to list");
                        Console.WriteLine("2. Remove an audio from list");
                        Console.WriteLine("3. Seek an audio from list");
                        Console.WriteLine("4. Sort an audio to list");
                        Console.WriteLine("5. Remove all audio from list");
                        Console.WriteLine("6. View all audio from list");
                        Console.Write("Please choose an option(1-6).Press E to exit: ");
                        string option = Console.ReadLine();

                        switch(option)
                        {
                            case "1":
                                Console.WriteLine("Choose an audio to add to playlist(1-3): \n1.audio1\n2.audio2\n3.audio3\n");
                                string audioAdd = Console.ReadLine();
                                if(audioAdd == "1")
                                {
                                    mediaPlayer.AddAudio(audio1);
                                }
                                else if(audioAdd == "2")
                                {
                                    mediaPlayer.AddAudio(audio2);
                                }
                                else if(audioAdd == "3")
                                {
                                    mediaPlayer.AddAudio(audio3);
                                }
                                else 
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Enter the name the audio file that you want to remove: ");
                                string titleRemove = Console.ReadLine();
                                Console.WriteLine("Enter the author of that audio file: ");
                                string authorRemove = Console.ReadLine();
                                mediaPlayer.RemoveAudio(titleRemove,authorRemove);
                                break;
                            case "3":
                                Console.WriteLine("Enter the name of the audio file: ");
                                string audioTitle = Console.ReadLine();
                                mediaPlayer.SeekAudio(audioTitle);
                                break;
                            case "4":
                                Console.WriteLine("Sort by (1-2): \n1. Title\n2. Author:");
                                string sortType = Console.ReadLine();
                                if(sortType == "1") 
                                {
                                    mediaPlayer.SortAudio("title");
                                }
                                else if(sortType =="2")
                                {
                                    mediaPlayer.SortAudio("author");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case "5":
                                Console.WriteLine("Are you sure to remove all the list(Y/N): ");
                                string answ = Console.ReadLine();
                                if(answ == "Y" || answ == "y") 
                                {   
                                    mediaPlayer.RemoveAllAudio();
                                    Console.WriteLine("Remove all the playlists.");
                                }
                                break;
                            case "6":
                                Console.WriteLine("This is the audio list: ");
                                mediaPlayer.ViewAudioPlaylist();
                                break;
                            case "E":
                                manageAudio = false;
                                break;
                            default: 
                                Console.WriteLine("Invalid input");
                                break;
                        }
                    }
                }
                else if (input == "4")
                {
                    bool manageVideo = true;
                    while(manageVideo) 
                    {
                        Console.WriteLine("1. Add an video to list");
                        Console.WriteLine("2. Remove an video from list");
                        Console.WriteLine("3. Seek an video from list");
                        Console.WriteLine("4. Sort an video to list");
                        Console.WriteLine("5. Remove all video from list");
                        Console.WriteLine("6. View all video from list");
                        Console.Write("Please choose an option(1-6).Press E to exit: ");
                        string option = Console.ReadLine();

                        switch(option)
                        {
                            case "1":
                                Console.WriteLine("Choose an video to add to playlist(1-3): \n1. video1\n2.video2\n3.video3\n");
                                string audioAdd = Console.ReadLine();
                                if(audioAdd == "1")
                                {
                                    mediaPlayer.AddVideo(video1);
                                }
                                else if(audioAdd == "2")
                                {
                                    mediaPlayer.AddVideo(video2);
                                }
                                else if(audioAdd == "3")
                                {
                                    mediaPlayer.AddVideo(video3);
                                }
                                else 
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Enter the name the video file that you want to remove: ");
                                string titleRemove = Console.ReadLine();
                                Console.WriteLine("Enter the author of that video file: ");
                                string authorRemove = Console.ReadLine();
                                mediaPlayer.RemoveVideo(titleRemove,authorRemove);
                                break;
                            case "3":
                                Console.WriteLine("Enter the name of the video file: ");
                                string videoTitle = Console.ReadLine();
                                mediaPlayer.SeekVideo(videoTitle);
                                break;
                            case "4":
                                Console.WriteLine("Sort by (1-2): \n1. Title\n2. Author");
                                string sortType = Console.ReadLine();
                                if(sortType == "1") 
                                {
                                    mediaPlayer.SortVideo("title");
                                }
                                else if(sortType =="2")
                                {
                                    mediaPlayer.SortVideo("author");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case "5":
                                Console.WriteLine("Are you sure to remove all the list(Y/N): ");
                                string answ = Console.ReadLine();
                                if(answ == "Y" || answ == "y") 
                                {   
                                    mediaPlayer.RemoveAllVideo();
                                    Console.WriteLine("Remove all the playlists.");
                                }
                                break;
                            case "6":
                                Console.WriteLine("This is the video list: ");
                                mediaPlayer.ViewVideoPlaylist();
                                break;
                            case "E":
                                manageVideo = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input.");
                                break;
                        }
                    }
                }
                else if (input == "E")
                {
                    open = false;
                }
                else 
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        static void PlayAudio(Audio audio,string option) 
        {
            if(option == "1") 
            {
                audio.Play("00:00");
            }
            else if(option == "2")
            {
                audio.Pause("2:00");
            }
            else if(option == "3")
            {
                audio.Stop("2:30");
            }
            else if(option == "4")
            {
                audio.Seek();
            }
        }

        static void PlayVideo(Video video,string option) 
        {
            if(option == "1") 
            {
                video.Play("00:00");
            }
            else if(option == "2")
            {
                video.Pause("2:00");
            }
            else if(option == "3")
            {
                video.Stop("2:30");
            }
            else if(option == "4")
            {
                video.Seek();
            }
        }

        static string ChooseOption()
        {
            Console.WriteLine("1. Play this file");
            Console.WriteLine("2. Pause this file");
            Console.WriteLine("3. Stop this file");
            Console.WriteLine("4. Seek the file");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();
            return option;
        }
    } 
}
