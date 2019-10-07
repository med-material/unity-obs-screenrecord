# unity-obs-screenrecord
Script to automatically screen record unity projects for using [Open Broadcaster Software](https://obsproject.com/) (OBS).

This project provides a Unitypackage which can be used to start/stop OBS screen recording without interrupting Unity. It works by starting OBS in the background, using the following commandline:

`C:\\Program Files\\obs-studio\\bin\\64bit\\obs64.exe --startrecording --minimize-to-tray`

When the application is quit, the OBS process is killed. Make sure your OBS is set up to record in a format which can playback despite such an interruption (for example, use `x264`).

The advantage of using OBS is that you can also set up recording of e.g. camera feeds, connected to the laptop and more.
