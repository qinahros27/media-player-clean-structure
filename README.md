# Introduction 
This project builds a media player application that demonstrates advanced topics in C# programming, including solid, clean architecture, Factory pattern, Singleton pattern, Observer pattern, object lifetime, and thread safety.

## Table of content
- Technologies
- Project structure
- Getting started

## Technologies 
- C#

## Project structure
```
.
└───MediaPlayer
    └───src
        └───Clean
            └───Controller
            └───Entity
                └───Factory
                └───Observer
            └───Infrastructure
                └───Singleton
                └───Program.cs
            └───Service
                └───Audios
                └───Videos
        └───ErrorHelper
    └───.gitignore
    └───MediaPlayer.csproj
    └───README.md   
```

## Getting started
Clone the respository from github: ```git clone```

<!---
## Description

The media player application is a robust software that meets the requirements by providing essential functionalities:

1. Playback Functionality:

- Users should be able to play audio and video files.
- Provide controls for play, pause, stop, and seek functionality.
- Display the current playback status, such as the current position and duration.

2. Media Management:

- Users should be able to manage their media library, including adding, removing, and organizing media files.
- Implement features to manage playlists.

3. Command-Line Interface:

- Design a user-friendly command-line interface that allows users to navigate and interact with the application.
- Provide clear instructions and feedback to guide users through different operations.

4. Error Handling:

- Handle potential errors and exceptions gracefully, providing meaningful error messages to the user.

## Requirements:

- Design a solid and clean architecture for the media player application.
- Implement the Factory pattern to create different types of media players, such as audio player and video player.
- Implement the Singleton pattern to ensure there is only one instance of the media player manager throughout the application.
- Implement the Observer pattern to allow the media player manager to notify other components of the application about playback events, such as play, pause, and stop.
- Manage object lifetimes appropriately.
- Ensure thread safety by handling concurrent access to shared resources, such as the media player manager.
--->