intelliSpy
==========
Turns Your PC Into An Intelligent Spy



What is intelliSpy?

1. 'intelliSpy' is an intelligent Spying application which makes use of webcam or/and microphone
2. It is written in C#. It makes use of AForge.NET, Kellerman-Encryption-Library, DOTNETZIP. All these libaries are open     source(Except kellerman).
3. .NET version 2.0+ are supported.


How does it work?

1. intelliSpy takes feed from any camera(webcam/USB camera) connected to your PC.
2. It then processes every single frame for detecting motion.
3. If motion detected is more than the threshold value then alarm is raised(both audio and visual).


Building from source?

1. The main branch is compile-able with Visual Studio 2012[tested].
2. Any version from VS 2008 should be able to compile the source[untested].
