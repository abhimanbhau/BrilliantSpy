intelliSpy
==========

Turns Your PC Into An Intelligent Spy

What is intelliSpy?

'intelliSpy' is an intelligent Spying application which makes use of webcam or/and microphone
It is written in C#. It makes use of AForge.NET, Kellerman-Encryption-Library, DOTNETZIP. All these libaries are open source(Except kellerman).
.Net version 2.0+ are supported.
How does it work?

intelliSpy takes feed from any camera(webcam/USB camera) connected to your PC.
It then processes every single frame for detecting motion.
If motion detected is more than the threshold value then alarm is raised(both audio and visual).
Building from source?

The main branch is compile-able with Visual Studio 2012[tested].
Any version from VS 2008 should be able to compile the source[untested].
