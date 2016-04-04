# Unity Gear VR boilerplate

This repository can be used as a starting point for building Samsung Gear VR apps in Unity 5.

If you are new to Gear VR development, chapter 4 in the book "Learning Virtual Reality" is highly recommended. It's currently available online here:
https://www.safaribooksonline.com/library/view/learning-virtual-reality/9781491922828/ch04.html

## Building the project

You will need to download and install a few things to be able to build this project.

### Install required Unity version

To develop for Oculus 1.3 you'll NEED to specifically be using Unity 5.3.4p1:
http://unity3d.com/unity/qa/patch-releases/5.3.4p1

### Patch Unity's Oculus plugin

You will also NEED to download the OVRPlugin separately and patch Unity:
https://developer.oculus.com/downloads/game-engines/1.3.0/OVRPlugin_for_Unity_5/

Unpack the downloaded file and replace Unity's `oculus` directory with the downloaded `oculus` directory.

On OSX, the `oculus` directory is located by default at `/Applications/Unity/Unity.app/Contents/VR`.
on Windows, the `oculus` directory is located by default at `C:\Program Files\Unity\Editor\Data\VR\oculus`.

For more information, see https://developer.oculus.com/documentation/game-engines/latest/concepts/unity-ovrplugin-130/.

### Install Android SDK

Download the Android SDK from:
http://developer.android.com/sdk/index.html#Other

Unpack (OSX) or install (Windows) the downloaded SDK in a directory of your own choice.

In Unity, go to Unity -> Preferences and select the `External Tools` tab. Click the `browse` button for Android SDK and select the directory where you placed the Android SDK.

For more information, see:
* https://developer.oculus.com/documentation/game-engines/latest/concepts/unity-mobileprep/
* http://docs.unity3d.com/Manual/android-sdksetup.html

### Install Java Development Kit

Download the latest JDK here and install it:
http://www.oracle.com/technetwork/java/javase/downloads/index.html

In Unity, go to Unity -> Preferences and select the `External Tools` tab. Verify that Android JDK is set to a path. If not, try building the project and Unity should autodetect the path. If not, the default path on OSX is `/Library/Java/JavaVirtualMachines/jdk[version].jdk/Contents/Home/`.

## Testing on the phone

To be able to build and test directly from Unity on your Android phone - with and without Gear VR - you must do a few things.

### Connect your Android phone to your computer via USB

Unlock the phone and connect to the computer via USB. Approve any prompts on the phone to trust the computer and grant it access.

In Windows 8 and 10, most Android phone will be immediately recognized when you connect it.

On OSX, you will need to install Android File Transfer to get the phone properly connected:
https://www.android.com/filetransfer/

Make sure have enabled Development Mode on the phone following these steps:
https://developer.oculus.com/documentation/mobilesdk/latest/concepts/mobile-android-debug/

### Download an Oculus Signature File (osig) for your phone

In a terminal window, go to the directory where you installed the Android SDK. Change into the `platform-tools` directory and run this command (omit the prefixed `./` on Windows):

```
./adb devices
```

Go to https://developer.oculus.com/osig/ (make sure you are logged in with your Oculus Developer account) and paste the device id output from the command above into the input field.

Click the `Download File` button and save file in `/Assets/Plugins/Android/assets/` relative to root of this boilerplate Unity project.

### Enable VR developer mode

This is an optional step if you want to be able to view the application in stereo mode on the phone without inserting it into the Gear VR. Follow the steps here:

https://developer.oculus.com/documentation/mobilesdk/latest/concepts/mobile-troublesh-device-run-app-outside/

### Build and run the project

Press Command/Ctrl + B or go to File -> Build & Run. Give the package any name and save it anywhere on your computer.

If all the steps above have been completed successfully, you should - once the build and publishing process in Unity completes - be prompted to insert your phone into the Gear VR and see the scene.

If you have enabled VR developer mode, the app should launch directly - however, you will not be able to look or move around as this relies on senors and the touchpad in the Gear VR.

After this, you will now have an app on your phone called `unity-gearvr-boilerplate` that you can start manually, and which Unity will update whenever you Build & Run the project with the phone connected via USB.

## Download summary

* Unity 5.3.4p1: http://unity3d.com/unity/qa/patch-releases/5.3.4p1
* Android SDK: http://developer.android.com/sdk/index.html#Other
* Oracle JDK: http://www.oracle.com/technetwork/java/javase/downloads/index.html
* Oculus Mobile SDK 1.0.0.1: https://developer.oculus.com/downloads/mobile/1.0.0.1/Oculus_Mobile_SDK/
* OVRPlugin for Unity 5: https://developer.oculus.com/downloads/game-engines/1.3.0/OVRPlugin_for_Unity_5/
* Oculus Utilities for Unity V1.3.0: https://developer.oculus.com/downloads/game-engines/1.3.0/Oculus_Utilities_for_Unity_5/
