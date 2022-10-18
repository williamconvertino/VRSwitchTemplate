# Building for the Quest 2

* Select Android build setting
* Set "Max Texture Size" to 2048 and apply
* Set the texture to ASTC
* Select the quest in the "Run Device" dropdown (make sure the headset is plugged in + developer mode is enabled)
* Turn off developer mode (if making production build)
* Use "Build and Run" to have it automatically sideload and run on Quest

# Testing in Unity (in Play mode)

* Connect the Quest to the Oculus desktop app (either by airlink or by plugging it in to the computer with the appropriate cable)
* Run SteamVR
[Note: SteamVR should detect the headset. If not, make sure you've connected to link/airlink from the Quest. If the headset is failing to connect to link/airlink, restart it. Every time I do a build it tends to need a reset before I can test again]
* When you press "Play," it should launch the game on the Quest from SteamVR