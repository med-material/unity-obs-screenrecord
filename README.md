# unity-obs-screenrecord
Script to automatically screen record unity projects for using [Open Broadcaster Software](https://obsproject.com/) (OBS).

This project provides a Unitypackage which can be used to start/stop OBS screen recording without interrupting Unity. It works by starting OBS in the background, using the following commandline:

`C:\\Program Files\\obs-studio\\bin\\64bit\\obs64.exe --startrecording --minimize-to-tray`

When the application is quit, the OBS process is killed. Make sure your OBS is set up to record in a format which can playback despite such an interruption (for example, use `x264`).

The advantage of using OBS is that you can also set up recording of e.g. camera feeds, connected to the laptop and more.

### Download and installation instructions

 1. Download [Open Broadcaster Software](https://obsproject.com/) and configure it to your needs.
 1. Download the [OBS Screenrecord Unity package](https://github.com/med-material/unity-obs-screenrecord/releases).
 1. Install the Unity OBS Screenrecord package in Unity (Assets -> Import Package -> Custom Package).
 1. Press the Play button in Unity. You should now see the OBS tray icon appear in the bottom. When you press Stop, the process is killed.
