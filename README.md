# Unity Gear VR boilerplate

This repository can be used as a starting point for building Samsung Gear VR apps in Unity 5.

## Getting started

You will need to download and install a few things for this boilerplate to work.

### Install required Unity version

To develop for Oculus 1.3 you'll NEED to specifically be using Unity 5.3.4p1:
http://unity3d.com/unity/qa/patch-releases/5.3.4p1

### Patch Unity's Oculus plugin

You will also NEED to download the OVRPlugin separately and patch Unity:
https://developer.oculus.com/downloads/game-engines/1.3.0/OVRPlugin_for_Unity_5/

Unpack the downloaded file and replace Unity's `oculus` directory with the downloaded `oculus` directory.

On OSX, the `oculus` directory is located by default at `/Applications/Unity/Unity.app/Contents/VR`.

### Install Android SDK

Download the Android SDK from:
http://developer.android.com/sdk/index.html#Other

Unpack (OSX) or install (Windows) the downloaded SDK in a directory of your own choice.

In Unity, go to Unity -> Preferences and select the `External Tools` tab. Click the `browse` button for Android SDK and select the directory where you placed the Android SDK.

### Install Java Development Kit

Download the latest JDK here and install it:
http://www.oracle.com/technetwork/java/javase/downloads/index.html

In Unity, go to Unity -> Preferences and select the `External Tools` tab. Verify that Android JDK is set to a path. If not, try building the project and Unity should autodetect the path. If not, the default path on OSX is `/Library/Java/JavaVirtualMachines/jdk[version].jdk/Contents/Home/`.

## Downloads

* Unity 5.3.4p1: http://unity3d.com/unity/qa/patch-releases/5.3.4p1
* Oculus Mobile SDK 1.0.0.1: https://developer.oculus.com/downloads/mobile/1.0.0.1/Oculus_Mobile_SDK/
* OVRPlugin for Unity 5: https://developer.oculus.com/downloads/game-engines/1.3.0/OVRPlugin_for_Unity_5/
* Oculus Utilities for Unity V1.3.0: https://developer.oculus.com/downloads/game-engines/1.3.0/Oculus_Utilities_for_Unity_5/
